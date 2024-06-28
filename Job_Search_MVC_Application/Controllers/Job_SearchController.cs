using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job_Search_MVC_Application.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Job_Search_MVC_Application.Controllers
{
    public class Job_SearchController : Controller
    {
        Job_Search_MVCEntities dbobj = new Job_Search_MVCEntities();
        // GET: Job_Search
        public ActionResult Searchjob_Pageload()
        {
            return View(GetData());
        }
        private JobSearch GetData()
        {
            var joblist = new JobSearch();
            List<string> lst = new List<string>();
            var job = dbobj.Job_Tab.ToList();
            foreach (var e in job)
            {
                var jobcls = new jsearch();
                jobcls.job_id = e.Job_Id;
                jobcls.company_id= e.Company_Id;
                jobcls.jobname = e.Job_Name;
                jobcls.numofvacancy = e.NumOfVacancy;
                jobcls.reqskills = e.Required_Skills;
                jobcls.salary = e.Salary;
                jobcls.qualification = e.Qualification;
                jobcls.jobstatus = e.Status;
                jobcls.entrydate = e.Entry_date;
                jobcls.lastdate = e.Last_ApplyDate;
                joblist.selectjob.Add(jobcls);
                var s = jobcls.reqskills;
                lst.Add(s);
                TempData["ski"] = string.Join("", lst);

            }
            return joblist;
        }
        public ActionResult searchjob_click(JobSearch clsobj)
        {
            string qry = "";
            if (!string.IsNullOrWhiteSpace(clsobj.insertse.jobname))
            {
                qry += "and Job_Name like '%" + clsobj.insertse.jobname+ "%'";


            }
            if (!string.IsNullOrWhiteSpace(clsobj.insertse.reqskills))
            {
                qry += "and Required_Skills like '%" + clsobj.insertse.reqskills + "%'";

            }
            return View("Searchjob_Pageload", getdata1(clsobj, qry));


        }
        private JobSearch getdata1(JobSearch clsobj, string qry)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["test"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_JS_Check2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@qry", qry);
                con.Open();
                    {
                    SqlDataReader dr = cmd.ExecuteReader();
                    var joblist = new JobSearch();
                    while (dr.Read())
                    {
                        var jobcls = new jsearch();
                        jobcls.job_id = Convert.ToInt32(dr["Job_Id"].ToString());
                        jobcls.company_id= Convert.ToInt32(dr["Company_Id"].ToString());
                        jobcls.jobname = dr["Job_Name"].ToString();
                        jobcls.numofvacancy= Convert.ToInt32(dr["NumOfVacancy"].ToString());
                        jobcls.reqskills = dr["Required_Skills"].ToString();
                        jobcls.salary= Convert.ToInt32(dr["Salary"].ToString());
                        jobcls.qualification = dr["Qualification"].ToString();
                        jobcls.jobstatus = dr["Status"].ToString();
                        jobcls.entrydate = Convert.ToDateTime(dr["Entry_date"].ToString());
                        jobcls.lastdate = Convert.ToDateTime(dr["Last_ApplyDate"].ToString());
                        joblist.selectjob.Add(jobcls);

                    }
                    con.Close();
                    return joblist;
                }
            }
        }

    }
}