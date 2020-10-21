using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeaveManagement.ViewModels
{
    public class EmployeeProfileViewModel
    {
        [Required]
        public string EmployeeFirstName { get; set; }

        [Required]
        public string EmployeeLastName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}