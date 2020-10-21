using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeaveManagement.DataModels;

namespace LeaveManagement.Repositories
{
    public interface IPMRepository
    {
        void LeaveApproval(LeaveData l);
        List<LeaveData> ViewAllLeave(int eid);
        LeaveData ViewLeaveByLeaveID(int eid, int lid);

    }
    public class PMRepository:IPMRepository
    {
        LeaveManagementDbContext db;
        public PMRepository()
        {
            db = new LeaveManagementDbContext();
        }
        public void LeaveApproval(LeaveData l)
        {
            LeaveData ld;
            ld = db.LeaveDatas.Where(temp => temp.EmployeeID == l.EmployeeID).FirstOrDefault();
            ld.ApprovalStatus = l.ApprovalStatus;
            db.SaveChanges();

        }
        public LeaveData ViewLeaveByLeaveID(int lid, int eid)
        {
            LeaveData ld;
            ld = db.LeaveDatas.Where(temp => temp.EmployeeID == eid && temp.ID == lid).FirstOrDefault();
            return ld;

        }
        public List<LeaveData> ViewAllLeave(int eid)
        {
            List<LeaveData> ld;
            ld = db.LeaveDatas.Where(temp => temp.EmployeeID == eid).ToList();
            return ld;

        }
    }
}