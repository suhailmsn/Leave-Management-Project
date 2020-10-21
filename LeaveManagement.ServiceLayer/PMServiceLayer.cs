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
    public interface IPMServiceLayer
    {
        void LeaveApproval(LeaveViewModel lvm);
    }
    public class PMServiceLayer : IPMServiceLayer
    {
        IPMRepository pr;
        public PMServiceLayer()
        {
            pr = new PMRepository();
        }
        public void LeaveApproval(LeaveViewModel lvm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<LeaveViewModel,LeaveData>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            LeaveData l = mapper.Map<LeaveViewModel, LeaveData>(lvm);
            pr.LeaveApproval(l);
        }
    }
}