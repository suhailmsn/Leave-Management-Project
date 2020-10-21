using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.DataModels
{
    public class EmployeeInfo : BaseEntity<int>
    {
        public string ProjectsDone { get; set; }
        public string Bio { get; set; }
        public string Hobbies { get; set; }
        public string Address { get; set; }
        public float Contact { get; set; }        
        public int EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

    }
}