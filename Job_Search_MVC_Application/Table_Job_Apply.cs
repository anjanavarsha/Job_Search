//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Job_Search_MVC_Application
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Job_Apply
    {
        public int Apply_Id { get; set; }
        public int Job_Id { get; set; }
        public int Company_Id { get; set; }
        public int User_Id { get; set; }
        public System.DateTime Apply_Date { get; set; }
        public string Resume { get; set; }
        public string Apply_Status { get; set; }
    }
}
