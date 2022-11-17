using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;
using System.Web.Http;
using employee_core_2._0.Data;
using employee_core_2._0.Interfaces;
using employee_core_2._0.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Net;
using System.Net.Http;
using employee_core_2._0.Services;
using System.Collections;
using System.Web.UI.WebControls.WebParts;

namespace employee_core_2._0.Repository
{
    public class JobdeptRepository :ApiController, IJobdeptRepository
    {
        private employee_core_2_0Context db = new employee_core_2_0Context();

        [ResponseType(typeof(Jobdept))]
        public Jobdept GetJobdept(int id)
        {
            Jobdept jobdept = db.jobdepts.Find(id);
            if (jobdept == null)
            {
                throw new Exception("not found");
            }

            return jobdept;
        }

        public IQueryable<Jobdept> Getjobdepts()
        {
            return db.jobdepts;
        }

        [ResponseType(typeof(Jobdept))]
        public Jobdept Postjobdept(Jobdept jobdept)
        {
            try
            {
                db.jobdepts.Add(jobdept);
                db.SaveChanges();
                return jobdept;
            }
            catch
            {
                throw new Exception("not found");
            }
        }

        [ResponseType(typeof(Jobdept))]
        public Jobdept Putjobdept( Jobdept jobdept)
        {

            if (jobdept.job_id<=0)
            {
                throw new Exception("not found");
            }

            db.Entry(jobdept).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("not found");
            }

            return jobdept;
        }


        [ResponseType(typeof(Jobdept))]
        public Jobdept Deletejobdept(int id)
        {
            Jobdept jobdept = db.jobdepts.Find(id);
            if (jobdept == null)
            {
                throw new Exception("not found");
            }

            db.jobdepts.Remove(jobdept);
            db.SaveChanges();

            return jobdept;
        }

        [ResponseType(typeof(Dictionary<int, int>))]
        public Dictionary<int, int> Getjobdeptsal(int sal)
        {
            var ids = (from i in db.jobdepts where i.salary_range == sal select i.emp_id).ToList();
            var salary = (from i in db.jobdepts where i.salary_range == sal select i.salary_range).ToList();
            var dict = Enumerable.Range(0, ids.Count).ToDictionary(i => ids[i], i => salary[i]);
            return dict;
        }

      [ResponseType(typeof(long))]
        public long Getfinallsal(int job_id)
        {
            var sal_range = (from i in db.jobdepts where i.emp_id == job_id select i.salary_range).ToArray();
            var count1 = (from i in db.leaves where i.emp_id == job_id select i.emp_id).Count(); //select count(*) from db.leaves where db.jobdepts.job_id==parms
            long sal_month = sal_range[0]/ 12;
            long sal_day = sal_month/ 20;
            long sal_loss_leave = count1*sal_day;
            long final = sal_month - sal_loss_leave;
            return final;
        }

        public IQueryable<Jobdept> GetSalrangeFilter(int value)
        {
            var a = (from i in db.jobdepts where i.salary_range <= value select i);
            return (a);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool jobdeptExists(int id)
        {
            return db.jobdepts.Count(e => e.job_id == id) > 0;
        }

    }
}