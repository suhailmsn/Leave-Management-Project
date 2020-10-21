using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeaveManagement.ViewModels
{
    public class EmployeeInfoViewModel
    {
        public string ProjectsDone { get; set; }
        public string Bio { get; set; }
        public string Hobbies { get; set; }
        public string Address { get; set; }

        [Required]
        public float Contact { get; set; }
        public int EmployeeID { get; set; }
    }
}