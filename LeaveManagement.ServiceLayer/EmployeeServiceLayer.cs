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
    public interface IEmployeeServiceLayer
    {
        void ApplyLeave(NewLeaveViewModel lvm);
        List<LeaveViewModel> ViewAllLeave(int eid);
        LeaveViewModel ViewLeaveByLeaveID(int eid, int lid);
        void UpdateEmployeeInfo(EmployeeInfoViewModel evm);
        void UpdateEmployeeEducation(EmployeeEducationViewModel evm);
        EmployeeProfileViewModel ViewEmployeeProfile(int eid);
        EmployeeEducationViewModel ViewEmployeeEducation(int eid);
        EmployeeInfoViewModel ViewEmployeeInfo(int eid);
    }
    public class EmployeeServiceLayer:IEmployeeServiceLayer
    {
        IEmployeeRepository er;

        public EmployeeServiceLayer()
        {
            er = new EmployeeRepository();
        }

        public void ApplyLeave(NewLeaveViewModel lvm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<NewLeaveViewModel, LeaveData>(); cfg.IgnoreUnmapped(); }) ;
            IMapper mapper = config.CreateMapper();
            LeaveData l = mapper.Map<NewLeaveViewModel, LeaveData>(lvm);
            er.ApplyLeave(l);
        }
        public List<LeaveViewModel> ViewAllLeave(int eid)
        {
            List<LeaveData> ld= er.ViewAllLeave(eid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<LeaveData, LeaveViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            List<LeaveViewModel> lvm = mapper.Map<List<LeaveData>,List<LeaveViewModel>>(ld);
            return lvm;
            
        }
        public LeaveViewModel ViewLeaveByLeaveID(int eid, int lid)
        {
            LeaveData ld = er.ViewLeaveByLeaveID(eid,lid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<LeaveData, LeaveViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            LeaveViewModel lvm = mapper.Map<LeaveData, LeaveViewModel>(ld);
            return lvm;
        }
        public void UpdateEmployeeInfo(EmployeeInfoViewModel evm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeInfoViewModel,EmployeeInfo>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeInfo e = mapper.Map<EmployeeInfoViewModel, EmployeeInfo>(evm);
            er.UpdateEmployeeInfo(e);
        }
        public void UpdateEmployeeEducation(EmployeeEducationViewModel evm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeEducationViewModel,EmployeeEducation>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeEducation e = mapper.Map<EmployeeEducationViewModel,EmployeeEducation>(evm);
            er.UpdateEmployeeEducation(e);
        }
        public EmployeeProfileViewModel ViewEmployeeProfile(int eid)
        {
            Employee e = er.ViewEmployeeProfile(eid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Employee,EmployeeProfileViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeProfileViewModel evm = mapper.Map<Employee,EmployeeProfileViewModel>(e);
            return evm;
        }
        public EmployeeEducationViewModel ViewEmployeeEducation(int eid)
        {
            EmployeeEducation e = er.ViewEmployeeEducation(eid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeEducation, EmployeeEducationViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeEducationViewModel evm = mapper.Map<EmployeeEducation, EmployeeEducationViewModel>(e);
            return evm;
        }
        public EmployeeInfoViewModel ViewEmployeeInfo(int eid)
        {
            EmployeeInfo e = er.ViewEmployeeInfo(eid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeInfo,EmployeeInfoViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeInfoViewModel evm = mapper.Map<EmployeeInfo, EmployeeInfoViewModel>(e);
            return evm;
        }
    }    
}