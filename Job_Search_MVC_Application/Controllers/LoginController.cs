using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job_Search_MVC_Application.Models;

namespace Job_Search_MVC_Application.Controllers
{
    public class LoginController : Controller
    {
        Job_Search_MVCEntities dbobj = new Job_Search_MVCEntities();
        // GET: Login
        public ActionResult Login_Pageload()
        {
            return View();
        }
        public ActionResult UserHomePage()
        {
            return View();
        }
        public ActionResult AdminCompanyHomePage()
        {
            return View();
        }
        public ActionResult Login_Click(Login clsobj)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_Login(clsobj.Username, clsobj.Password, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    var uid = dbobj.sp_GetLoginId(clsobj.Username, clsobj.Password).FirstOrDefault();
                    Session["uid"] = uid;

                    var LogType = dbobj.sp_GetLoginType(clsobj.Username, clsobj.Password).FirstOrDefault();
                    if (LogType == "user")
                    {
                        return RedirectToAction("UserHomePage");
                    }
                    else if (LogType == "admin")
                    {
                        return RedirectToAction("AdminCompanyHomePage");
                    }

                }
                else
                {
                    ModelState.Clear();
                    clsobj.msg = "Invalid Login";
                    return View("Login_Pageload", clsobj);
                }
            }
            return View("Login_Pageload", clsobj);

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}