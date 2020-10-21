using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.DataModels
{
    public class LeaveType : BaseEntity<int>
    {
        public string LeaveTypeName { get; set; }

    }
}