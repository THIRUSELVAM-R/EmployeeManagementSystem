using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using employee_core_2._0.Interfaces;
using employee_core_2._0.Models;
using employee_core_2._0.Repository;
using employee_core_2._0.Services;

namespace employee_core_2._0.Services
{
    public class LeaveServices:ILeaveServices
    {
        ILeaveRepository _leaveRepository;

        public LeaveServices(ILeaveRepository leaveRepository)
        {
            _leaveRepository = leaveRepository;
        }

        public IQueryable<Leave> Getleaves()
        {
            var result = _leaveRepository.Getleaves();
            return result;
        }

        public Leave Getleave(int id)
        {
            var result = _leaveRepository.Getleave(id);
            return result;
        }

        public Leave Postleave(Leave leave)
        {
            var result = _leaveRepository.Postleave(leave);
            return result;
        }

        public Leave Putleave(Leave leave)
        {
            var result = _leaveRepository.Putleave(leave);
            return result;
        }

        public Leave Deleteleave(int id)
        {
            var result = _leaveRepository.Deleteleave(id);
            return result;
        }
    }
}