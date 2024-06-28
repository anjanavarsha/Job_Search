using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job_Search_MVC_Application.Models;

namespace Job_Search_MVC_Application.Controllers
{
    public class ApplyJobController : Controller
    {
        Job_Search_MVCEntities dbobj = new Job_Search_MVCEntities();
            
        // GET: ApplyJob
        public ActionResult ApplyJob_Load(int cid,int jid)
        {
            TempData["cid"] = cid;
            TempData["jid"] = jid;
            return View();
        }
        public ActionResult ApplyJob_Click(JobApply clsobj, JobSearch obj, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/Resume");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);


                    var fullpath = Path.Combine("~/Resume", fname);
                    clsobj.resume = fullpath;

                }
                int uid = Convert.ToInt32(Session["uid"]);
                int cid = Convert.ToInt32(TempData["cid"]);
                int jid = Convert.ToInt32(TempData["jid"]);

                dbobj.sp_Apply_Job(jid, cid, uid, clsobj.applydate, clsobj.resume, "Available");
                clsobj.msg = "successfully applied";
                return View("ApplyJob_Load", clsobj);

            }
            return View("ApplyJob_Load", clsobj);
        }
    }
}