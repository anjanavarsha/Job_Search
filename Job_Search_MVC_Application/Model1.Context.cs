﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Job_Search_MVCEntities : DbContext
    {
        public Job_Search_MVCEntities()
            : base("name=Job_Search_MVCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Job_Tab> Job_Tab { get; set; }
        public virtual DbSet<Table_Company> Table_Company { get; set; }
        public virtual DbSet<Table_Job_Apply> Table_Job_Apply { get; set; }
        public virtual DbSet<Table_JobSearch> Table_JobSearch { get; set; }
        public virtual DbSet<Table_Login> Table_Login { get; set; }
        public virtual DbSet<Table_User> Table_User { get; set; }
    
        public virtual int sp_Apply_Job(Nullable<int> jid, Nullable<int> comid, Nullable<int> uid, Nullable<System.DateTime> applydate, string resume, string applystatus)
        {
            var jidParameter = jid.HasValue ?
                new ObjectParameter("jid", jid) :
                new ObjectParameter("jid", typeof(int));
    
            var comidParameter = comid.HasValue ?
                new ObjectParameter("comid", comid) :
                new ObjectParameter("comid", typeof(int));
    
            var uidParameter = uid.HasValue ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(int));
    
            var applydateParameter = applydate.HasValue ?
                new ObjectParameter("applydate", applydate) :
                new ObjectParameter("applydate", typeof(System.DateTime));
    
            var resumeParameter = resume != null ?
                new ObjectParameter("resume", resume) :
                new ObjectParameter("resume", typeof(string));
    
            var applystatusParameter = applystatus != null ?
                new ObjectParameter("applystatus", applystatus) :
                new ObjectParameter("applystatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Apply_Job", jidParameter, comidParameter, uidParameter, applydateParameter, resumeParameter, applystatusParameter);
        }
    
        public virtual int sp_CompanyRegister(Nullable<int> cid, string cname, string caddress, Nullable<long> cph, string cemail, string cstatus)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var cnameParameter = cname != null ?
                new ObjectParameter("cname", cname) :
                new ObjectParameter("cname", typeof(string));
    
            var caddressParameter = caddress != null ?
                new ObjectParameter("caddress", caddress) :
                new ObjectParameter("caddress", typeof(string));
    
            var cphParameter = cph.HasValue ?
                new ObjectParameter("cph", cph) :
                new ObjectParameter("cph", typeof(long));
    
            var cemailParameter = cemail != null ?
                new ObjectParameter("cemail", cemail) :
                new ObjectParameter("cemail", typeof(string));
    
            var cstatusParameter = cstatus != null ?
                new ObjectParameter("cstatus", cstatus) :
                new ObjectParameter("cstatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CompanyRegister", cidParameter, cnameParameter, caddressParameter, cphParameter, cemailParameter, cstatusParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_GetLoginId(string una, string pw)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("pw", pw) :
                new ObjectParameter("pw", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_GetLoginId", unaParameter, pwParameter);
        }
    
        public virtual ObjectResult<string> sp_GetLoginType(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_GetLoginType", unaParameter, pwdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_GetMaxIdLogin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_GetMaxIdLogin");
        }
    
        public virtual int sp_Job_Insert(Nullable<int> cid, string jname, Nullable<int> numofvacancy, string reqskils, string description, Nullable<int> salary, string qual, string status, Nullable<System.DateTime> entryDate, Nullable<System.DateTime> lastDate)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var jnameParameter = jname != null ?
                new ObjectParameter("jname", jname) :
                new ObjectParameter("jname", typeof(string));
    
            var numofvacancyParameter = numofvacancy.HasValue ?
                new ObjectParameter("numofvacancy", numofvacancy) :
                new ObjectParameter("numofvacancy", typeof(int));
    
            var reqskilsParameter = reqskils != null ?
                new ObjectParameter("reqskils", reqskils) :
                new ObjectParameter("reqskils", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            var qualParameter = qual != null ?
                new ObjectParameter("qual", qual) :
                new ObjectParameter("qual", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var entryDateParameter = entryDate.HasValue ?
                new ObjectParameter("entryDate", entryDate) :
                new ObjectParameter("entryDate", typeof(System.DateTime));
    
            var lastDateParameter = lastDate.HasValue ?
                new ObjectParameter("lastDate", lastDate) :
                new ObjectParameter("lastDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Job_Insert", cidParameter, jnameParameter, numofvacancyParameter, reqskilsParameter, descriptionParameter, salaryParameter, qualParameter, statusParameter, entryDateParameter, lastDateParameter);
        }
    
        public virtual ObjectResult<sp_JS_Check1_Result> sp_JS_Check1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_JS_Check1_Result>("sp_JS_Check1");
        }
    
        public virtual int sp_JS_Check2(string qry)
        {
            var qryParameter = qry != null ?
                new ObjectParameter("qry", qry) :
                new ObjectParameter("qry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_JS_Check2", qryParameter);
        }
    
        public virtual int sp_Login(string una, string pwd, ObjectParameter status)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Login", unaParameter, pwdParameter, status);
        }
    
        public virtual int sp_LoginInsert(Nullable<int> regid, string uname, string pwd, string logtype, string status)
        {
            var regidParameter = regid.HasValue ?
                new ObjectParameter("regid", regid) :
                new ObjectParameter("regid", typeof(int));
    
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            var logtypeParameter = logtype != null ?
                new ObjectParameter("logtype", logtype) :
                new ObjectParameter("logtype", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_LoginInsert", regidParameter, unameParameter, pwdParameter, logtypeParameter, statusParameter);
        }
    
        public virtual int sp_UserRegister(Nullable<int> uid, string uname, Nullable<int> uage, string uaddr, Nullable<long> uph, string uemail, Nullable<long> upincode, string ustate, string udist, string uqual, string uskills, string uexp, string ustatus)
        {
            var uidParameter = uid.HasValue ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(int));
    
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var uageParameter = uage.HasValue ?
                new ObjectParameter("uage", uage) :
                new ObjectParameter("uage", typeof(int));
    
            var uaddrParameter = uaddr != null ?
                new ObjectParameter("uaddr", uaddr) :
                new ObjectParameter("uaddr", typeof(string));
    
            var uphParameter = uph.HasValue ?
                new ObjectParameter("uph", uph) :
                new ObjectParameter("uph", typeof(long));
    
            var uemailParameter = uemail != null ?
                new ObjectParameter("uemail", uemail) :
                new ObjectParameter("uemail", typeof(string));
    
            var upincodeParameter = upincode.HasValue ?
                new ObjectParameter("upincode", upincode) :
                new ObjectParameter("upincode", typeof(long));
    
            var ustateParameter = ustate != null ?
                new ObjectParameter("ustate", ustate) :
                new ObjectParameter("ustate", typeof(string));
    
            var udistParameter = udist != null ?
                new ObjectParameter("udist", udist) :
                new ObjectParameter("udist", typeof(string));
    
            var uqualParameter = uqual != null ?
                new ObjectParameter("uqual", uqual) :
                new ObjectParameter("uqual", typeof(string));
    
            var uskillsParameter = uskills != null ?
                new ObjectParameter("uskills", uskills) :
                new ObjectParameter("uskills", typeof(string));
    
            var uexpParameter = uexp != null ?
                new ObjectParameter("uexp", uexp) :
                new ObjectParameter("uexp", typeof(string));
    
            var ustatusParameter = ustatus != null ?
                new ObjectParameter("ustatus", ustatus) :
                new ObjectParameter("ustatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UserRegister", uidParameter, unameParameter, uageParameter, uaddrParameter, uphParameter, uemailParameter, upincodeParameter, ustateParameter, udistParameter, uqualParameter, uskillsParameter, uexpParameter, ustatusParameter);
        }
    
        public virtual int sp_check(string qry)
        {
            var qryParameter = qry != null ?
                new ObjectParameter("qry", qry) :
                new ObjectParameter("qry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_check", qryParameter);
        }
    
        public virtual ObjectResult<sp_jsearch_Result> sp_jsearch()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_jsearch_Result>("sp_jsearch");
        }
    }
}
