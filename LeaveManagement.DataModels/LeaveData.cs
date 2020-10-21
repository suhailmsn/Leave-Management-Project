using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.DataModels
{
    public class LeaveData : BaseEntity<int>
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime DateOfRequest { get; set; }
        public int LeaveType { get; set; }
        public string LeaveReason { get; set; }
        public int ApprovalStatus { get; set; }
        public string ApprovedBy { get; set; }
        public int EmployeeID { get; set; }
        public int PMEmployeeID { get; set; }
        public int LeaveTypeID { get; set; }

        [ForeignKey("LeaveTypeID")]
        public virtual LeaveType Leavetype { get; set; }



    }
}