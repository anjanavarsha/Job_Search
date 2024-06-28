using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job_Search_MVC_Application.Models;

namespace Job_Search_MVC_Application.Controllers
{
    public class UserRegController : Controller
    {
        Job_Search_MVCEntities dbobj = new Job_Search_MVCEntities();
        // GET: UserReg
        public ActionResult UserInsert_Pageload()
        {

            return View();
        }

        public ActionResult UserInsert_Click(UserRegister clsobj)
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
                dbobj.sp_UserRegister(regid, clsobj.UsName, clsobj.UsAge, clsobj.UsAddress, clsobj.UsPhone, clsobj.UsEmail,clsobj.UsPincode,clsobj.UsState,clsobj.UsDist,clsobj.UsQual,clsobj.UsSkills,clsobj.UsExp,"active");
                dbobj.sp_LoginInsert(regid, clsobj.Username, clsobj.Password, "user","active");
                clsobj.Usermsg = "successfully inserted";

            }
            return View("UserInsert_Pageload", clsobj);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}