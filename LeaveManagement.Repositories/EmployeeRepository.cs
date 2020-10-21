using System;
using System.Collections.Generic;
using System.Linq;
using LeaveManagement.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Repositories
{
    public interface IEmployeeRepository
    {
        void ApplyLeave(LeaveData l);
        List<LeaveData> ViewAllLeave(int eid);
        LeaveData ViewLeaveByLeaveID(int eid, int lid);
        void UpdateEmployeeInfo(EmployeeInfo e);
        void UpdateEmployeeEducation(EmployeeEducation eid);
        Employee ViewEmployeeProfile(int eid);
        EmployeeEducation ViewEmployeeEducation(int eid);
        EmployeeInfo ViewEmployeeInfo(int eid);


    }
    public class EmployeeRepository:IEmployeeRepository
    {
        LeaveManagementDbContext db;
        public EmployeeRepository()
        {
            db = new LeaveManagementDbContext();
        }
        public void ApplyLeave(LeaveData l)
        {
            db.LeaveDatas.Add(l);
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
        public void UpdateEmployeeInfo(EmployeeInfo e)
        {
            EmployeeInfo ei;
            ei = db.EmployeeInfos.Where(temp => (temp.EmployeeID == e.ID)).FirstOrDefault();
            if(ei!=null)
            {
                ei.Hobbies = e.Hobbies;
                ei.ProjectsDone = e.ProjectsDone;
                ei.Bio = e.Bio;
                ei.Address = e.Address;
                ei.Contact = e.Contact;
                db.SaveChanges();
            }
        }
        public void UpdateEmployeeEducation(EmployeeEducation e)
        {
            EmployeeEducation ee;
            ee = db.EmployeeEducations.Where(temp => (temp.EmployeeID == e.ID)).FirstOrDefault();
            if (ee != null)
            {
                ee.Qualification = e.Qualification;
                ee.TenthGradeMark = e.TenthGradeMark;
                ee.TwelfthGradeMark = e.TwelfthGradeMark;
                ee.TwelfthSchoolName = e.TwelfthSchoolName;
                db.SaveChanges();
            }
        }
        public Employee ViewEmployeeProfile(int eid)
        {
            Employee ee;
            ee = db.Employees.Where(temp => (temp.ID == eid)).FirstOrDefault();
            return ee;

        }
        public EmployeeEducation ViewEmployeeEducation(int eid)
        {
            EmployeeEducation ee;
            ee = db.EmployeeEducations.Where(temp => (temp.EmployeeID == eid)).FirstOrDefault();
            return ee;
        }
        public EmployeeInfo ViewEmployeeInfo(int eid)
        {
            EmployeeInfo ei;
            ei = db.EmployeeInfos.Where(temp => (temp.EmployeeID == eid)).FirstOrDefault();
            return ei;
        }

    }
}