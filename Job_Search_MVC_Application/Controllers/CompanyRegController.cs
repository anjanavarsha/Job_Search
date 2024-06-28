using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job_Search_MVC_Application.Models;

namespace Job_Search_MVC_Application.Controllers
{
    public class CompanyRegController : Controller
    {
        Job_Search_MVCEntities dbobj = new Job_Search_MVCEntities();
        // GET: CompanyReg

        public ActionResult InsertCompany_Pageload()
        {
            return View();
        }
        public ActionResult InsertCompany_click(CompanyRegister clsobj)
        {
            if (ModelState.IsValid)
            {
                var getmaxid = dbobj.sp_GetMaxIdLogin().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if (mid == 0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }
                //get
                dbobj.sp_CompanyRegister(regid, clsobj.ComName, clsobj.ComAddress, clsobj.ComPhone, clsobj.ComEmail,"active");
                dbobj.sp_LoginInsert(regid, clsobj.Username, clsobj.Password, "admin","active");
                clsobj.ComMsg = "successfully inserted";

            }
            return View("InsertCompany_Pageload", clsobj);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}