//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstituteManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        public int StudentID { get; set; }
        public string RegNo { get; set; }
        public int Semester { get; set; }
        public double GPA { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
