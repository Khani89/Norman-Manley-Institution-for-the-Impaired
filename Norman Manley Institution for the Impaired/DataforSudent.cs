//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Norman_Manley_Institution_for_the_Impaired
{
    using System;
    using System.Collections.Generic;
    
    public partial class DataforSudent
    {
        public int id { get; set; }
        public Nullable<int> StudentNameid { get; set; }
        public string Nationality { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public string Program { get; set; }
        public string Disability { get; set; }
        public string Gender { get; set; }
        public string Grade { get; set; }
    
        public virtual DataforSudent DataforSudents1 { get; set; }
        public virtual DataforSudent DataforSudent1 { get; set; }
    }
}