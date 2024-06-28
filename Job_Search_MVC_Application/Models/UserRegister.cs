using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Search_MVC_Application.Models
{
    public class UserRegister
    {
        [Required(ErrorMessage = "enter your name")]
        public string UsName { get; set; }
        [Required(ErrorMessage = "enter your age")]
        public int UsAge { get; set; }
        [Required(ErrorMessage = "enter your address")]
        public string UsAddress { get; set; }

        [Required(ErrorMessage = "enter Phone number")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "enter valid number")]

        public long UsPhone { get; set; }

        [EmailAddress(ErrorMessage = "enter valid email")]

        public string UsEmail { get; set; }
        [Required(ErrorMessage = "enter pincode")]

        public long UsPincode { get; set; }
        [Required(ErrorMessage = "enter your state")]

        public string UsState { get; set; }
        [Required(ErrorMessage = "enter your district")]
        public string UsDist { get; set; }
        [Required(ErrorMessage = "enter qualification")]
        public string UsQual { get; set; }
        [Required(ErrorMessage = "enter your skills")]
        public string UsSkills { get; set; }
        [Required(ErrorMessage = "enter your experience")]
        public string UsExp { get; set; }
        
        //public string UsStatus { get; set; }


        [Required(ErrorMessage = "enter user name")]

        public string Username { get; set; }

        [Required(ErrorMessage = "enter Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password missmatch")]
        public string Confirmpassword { get; set; }

        public string Usermsg { get; set; }
    }
}