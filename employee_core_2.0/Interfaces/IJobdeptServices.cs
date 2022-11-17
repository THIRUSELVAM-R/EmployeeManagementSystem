using employee_core_2._0.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_core_2._0.Interfaces
{
    public interface IJobdeptServices
    {
        Jobdept GetJobdept(int id);

        IQueryable<Jobdept> Getjobdepts();

        Jobdept Postjobdept(Jobdept jobdept);

        Jobdept Putjobdept( Jobdept jobdept);

        Jobdept Deletejobdept(int id);

        Dictionary<int, int> Getjobdeptsal(int sal);

       long Getfinallsal(int job_id);

       IQueryable<Jobdept> GetSalrangeFilter(int value);
    }
}
