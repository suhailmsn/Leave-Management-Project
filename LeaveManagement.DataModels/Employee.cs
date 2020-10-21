using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.DataModels
{
    public class Employee : BaseEntity<int>
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }

        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public virtual List<EmployeeRole> EmployeeRoles { get; set; }
    }
}