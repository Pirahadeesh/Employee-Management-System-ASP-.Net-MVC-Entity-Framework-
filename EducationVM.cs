using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DGHCM.ViewModel
{
    public class EducationVM
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Amount { get; set; }
        public bool IsActive { get; set; }
        public string CourseName { get; set; }
        public string Institutions { get; set; }
        public int EducationId { get; set; }
        public string Document {  get; set; }
    }
}