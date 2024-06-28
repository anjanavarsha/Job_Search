using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Search_MVC_Application.Models
{
    public class Login
    {

        [Required(ErrorMessage = "enter user name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "enter password")]

        public string Password { get; set; }
        public string msg { get; set; }
        public string Ltype { get; set; }
    }
}