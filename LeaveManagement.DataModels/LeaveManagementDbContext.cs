using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace LeaveManagement.DataModels
{
    public class LeaveManagementDbContext:DbContext
    {
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<LeaveData> LeaveDatas { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }

    }
}