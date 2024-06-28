using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Job_Search_MVC_Application.Models
{
    public class JobApply
    {
        public int Applyjobid { get; set; }
        public int jobid { get; set; }
        public int companyid { get; set; }
        public int userid { get; set; }
        public string resume { get; set; }
        public DateTime applydate { get; set; }
        public string applystatus { get; set; }
        public string msg { get; set; }

    }
}