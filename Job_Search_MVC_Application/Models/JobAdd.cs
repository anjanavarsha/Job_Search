using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Job_Search_MVC_Application.Models
{
    public class JobAdd
    {
        public int comid { get; set; }
        public string jobname { get; set; }
        public int numofvacancy { get; set; }
        public string reqskills { get; set; }
        public string jobdescription{ get; set; }
        public int salary { get; set; }
        public string qualifi { get; set; }
        public string jstatus { get; set; }
        public DateTime entrydate { get; set; }
        public DateTime lastappldate { get; set; }
        public string msg { get; set; }

    }
}