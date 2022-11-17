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

namespace employee_core_2._0.Repository
{
    public class FinanceRepository : ApiController ,IFinanceRepository
    {
        private employee_core_2_0Context db = new employee_core_2_0Context();

        public IQueryable<Finance> Getfinances()
        {
            return db.finances;
        }

        [ResponseType(typeof(Finance))]
        public Finance Getfinance(int id)
        {
            Finance finance = db.finances.Find(id);
            if (finance == null)
            {
                throw new Exception("not found");
            }
            return finance;
        }

        [ResponseType(typeof(Finance))]
        public Finance Postfinance(Finance finance)
        {
            try
            {

                db.finances.Add(finance);
                db.SaveChanges();
                return finance;
            }
            catch
            {
                throw new Exception("not found");
            }
        }

        [ResponseType(typeof(Finance))]
        public Finance Putfinance(Finance finance)
        {

            if (finance.salary_id<=0)
            {
                throw new Exception("not found");
            }

            db.Entry(finance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("not found");
            }

            return finance;
        }

        [ResponseType(typeof(Finance))]
        public Finance Deletefinance(int id)
        {
            Finance finance = db.finances.Find(id);
            if (finance == null)
            {
                throw new Exception("not found");
            }

            db.finances.Remove(finance);
            db.SaveChanges();
            return finance;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool financeExists(int id)
        {
            return db.finances.Count(e => e.salary_id == id) > 0;
        }
    }
}