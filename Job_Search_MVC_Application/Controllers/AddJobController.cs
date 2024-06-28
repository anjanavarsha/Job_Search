using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job_Search_MVC_Application.Models;

namespace Job_Search_MVC_Application.Controllers
{
    public class AddJobController : Controller
    {
        Job_Search_MVCEntities dbobj = new Job_Search_MVCEntities();
        // GET: AddJob
        public ActionResult AddJob_PageLoad()
        {
            return View();
        }
        public ActionResult addjob_click(JobAdd clsobj)
        {
            if (ModelState.IsValid)
            {
                int cid = Convert.ToInt32(Session["uid"]);

                dbobj.sp_Job_Insert(cid, clsobj.jobname, clsobj.numofvacancy, clsobj.reqskills, clsobj.jobdescription, clsobj.salary, clsobj.qualifi, clsobj.jstatus, clsobj.entrydate, clsobj.lastappldate);
                clsobj.msg = "insert successfully";
            }
             
                return View("AddJob_PageLoad", clsobj);
            
        }
    }
}