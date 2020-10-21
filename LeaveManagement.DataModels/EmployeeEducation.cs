using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.DataModels
{
    public class EmployeeEducation : BaseEntity<int>
    {

        public string Qualification { get; set; }
        public float TenthGradeMark { get; set; }
        public float TwelfthGradeMark { get; set; }
        public string TwelfthSchoolName { get; set; }
        public int EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]

        public Employee Employee { get; set; }


    }
}