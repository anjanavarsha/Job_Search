using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Search_MVC_Application.Models
{
    public class CompanyRegister
    {

        [Required(ErrorMessage = "enter your name")]
        public string ComName { get; set; }

        [Required(ErrorMessage = "enter your Address")]
        public string ComAddress { get; set; }

        [Required(ErrorMessage = "enter Phone number")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "enter valid number")]

        public long ComPhone { get; set; }
        [EmailAddress(ErrorMessage = "enter valid email")]
        public string ComEmail { get; set; }

        [Required(ErrorMessage = "enter user name")]

        public string Username { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password missmatch")]
        public string Confirmpassword { get; set; }
        public string ComMsg { get; set; }
    }
}