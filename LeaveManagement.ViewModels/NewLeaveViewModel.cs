using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LeaveManagement.ViewModels
{
    public class NewLeaveViewModel
    {
        [Required]
        public DateTime FromDate { get; set; }

        [Required]
        public DateTime ToDate { get; set; }

        [Required]
        public DateTime DateOfRequest { get; set; }

        [Required]
        public int LeaveType { get; set; }

        [Required]
        public string LeaveReason { get; set; }

        [Required]
        public int ApprovalStatus { get; set; }

        [Required]
        public string ApprovedBy { get; set; }

        [Required]
        public int EmployeeID { get; set; }

    }
}