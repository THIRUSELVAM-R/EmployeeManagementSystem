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
    public class JobdeptServices:IJobdeptServices
    {
        IJobdeptRepository _jobdeptRepository;

        public JobdeptServices(IJobdeptRepository jobdeptRepository)
        {
            _jobdeptRepository = jobdeptRepository;
        }

        public Jobdept GetJobdept(int id)
        {
            var result = _jobdeptRepository.GetJobdept(id);
            return result;
        }

        public IQueryable<Jobdept> Getjobdepts()
        {
            var result = _jobdeptRepository.Getjobdepts();
            return result;
        }

        public Jobdept Postjobdept(Jobdept jobdept)
        {
            var result = _jobdeptRepository.Postjobdept(jobdept);
            return result;
        }

        public Jobdept Putjobdept( Jobdept jobdept)
        {
            var result = _jobdeptRepository.Putjobdept( jobdept);
            return result;
        }

        public Jobdept Deletejobdept(int id)
        {
            var result = _jobdeptRepository.Deletejobdept(id);
            return result;
        }

        public Dictionary<int, int> Getjobdeptsal(int sal)
        {
            var result = _jobdeptRepository.Getjobdeptsal(sal);
            return result;
        }

        public long Getfinallsal(int job_id)
        {
            var result = _jobdeptRepository.Getfinallsal(job_id);
            return result;
        }

        public IQueryable<Jobdept> GetSalrangeFilter(int value)
        {
            var result = _jobdeptRepository.GetSalrangeFilter(value);
            return result;
        }

    }
}