//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem.Main
{
    using System;
    using System.Collections.Generic;
    
    public partial class CurriculumDetail
    {
        public int ID { get; set; }
        public int ClassID { get; set; }
        public int SubjectID { get; set; }
    
        public virtual ClassInfo ClassInfo { get; set; }
        public virtual SubjectInfo SubjectInfo { get; set; }
    }
}