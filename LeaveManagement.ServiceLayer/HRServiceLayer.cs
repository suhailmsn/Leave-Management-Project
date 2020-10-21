using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using LeaveManagement.ViewModels;
using LeaveManagement.DataModels;
using LeaveManagement.Repositories;
using StackOverflowProject.ServiceLayer;

namespace LeaveManagement.ServiceLayer
{
    public interface IHRServiceLayer
    {
        void CreateEmployeeProfile(NewEmployeeViewModel evm);
        void UpdateEmployeeProfile(EmployeeProfileViewModel evm);
        List<LeaveViewModel> ViewAllLeave(int eid);
        LeaveViewModel ViewLeaveByLeaveID(int eid, int lid);
    }
    public class HRServiceLayer:IHRServiceLayer
    {
        IEmployeeRepository er;
        IHRRepository hr;

        public HRServiceLayer()
        {
            er = new EmployeeRepository();
            hr = new HRRepository();

        }

        public void CreateEmployeeProfile(NewEmployeeViewModel evm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<NewEmployeeViewModel,Employee>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            Employee l = mapper.Map<NewEmployeeViewModel,Employee>(evm);
            hr.CreateEmployeeProfile(l);
        }
        public void UpdateEmployeeProfile(EmployeeProfileViewModel evm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeProfileViewModel, Employee>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            Employee e = mapper.Map<EmployeeProfileViewModel, Employee>(evm);
            hr.UpdateEmployeeProfile(e);
        }
        public List<LeaveViewModel> ViewAllLeave(int eid)
        {
            List<LeaveData> ld = er.ViewAllLeave(eid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<LeaveData, LeaveViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            List<LeaveViewModel> lvm = mapper.Map<List<LeaveData>, List<LeaveViewModel>>(ld);
            return lvm;

        }
        public LeaveViewModel ViewLeaveByLeaveID(int eid, int lid)
        {
            LeaveData ld = er.ViewLeaveByLeaveID(eid, lid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<LeaveData, LeaveViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            LeaveViewModel lvm = mapper.Map<LeaveData, LeaveViewModel>(ld);
            return lvm;
        }

    }
}