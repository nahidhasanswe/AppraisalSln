//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositoryPattern
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeSummery
    {
        public System.Guid Id { get; set; }
        public string HeadOfDepartment { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<int> NumberOfEmployees { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}