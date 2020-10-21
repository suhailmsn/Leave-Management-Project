using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.DataModels
{
    public class EmployeeRole : BaseEntity<int>
    {
        public string RoleName { get; set; }
        public virtual List<Employee> Employee { get; set; }
    }
}