using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeaveManagement.ViewModels
{
    public class EmployeeEducationViewModel
    {
        [Required]
        public string Qualification { get; set; }

        [Required]
        public float TenthGradeMark { get; set; }

        [Required]
        public float TwelfthGradeMark { get; set; }

        [Required]
        public string TwelfthSchoolName { get; set; }
    }
}