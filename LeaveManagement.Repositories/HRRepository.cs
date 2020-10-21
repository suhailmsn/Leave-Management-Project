using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeaveManagement.DataModels;

namespace LeaveManagement.Repositories
{
    public interface IHRRepository
    {
        void CreateEmployeeProfile(Employee e);
        void UpdateEmployeeProfile(Employee e);
        List<LeaveData> ViewAllLeave(int eid);
        LeaveData ViewLeaveByLeaveID(int eid,int lid);

    }
    public class HRRepository : IHRRepository
    {
        LeaveManagementDbContext db;

        public HRRepository()
        {
            db = new LeaveManagementDbContext();
        }


        public void CreateEmployeeProfile(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            
        }
        public void UpdateEmployeeProfile(Employee e)
        {
            Employee ee;
            ee = db.Employees.Where(temp => (temp.ID == e.ID)).FirstOrDefault();
            if (ee != null)
            {
                ee.Email = e.Email;
                ee.EmployeeFirstName = e.EmployeeFirstName;
                ee.EmployeeLastName = e.EmployeeLastName;
                db.SaveChanges();
            }

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
            ld = db.LeaveDatas.Where(temp =>temp.EmployeeID == eid).ToList();
            return ld;

        }
    }
}