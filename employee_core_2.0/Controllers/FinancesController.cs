using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using employee_core_2._0.Data;
using employee_core_2._0.Interfaces;
using employee_core_2._0.Models;
using employee_core_2._0.Services;

namespace employee_core_2._0.Controllers
{
    public class FinancesController : ApiController
    {
        IFinanceServices _financeServices;
       

        public FinancesController(IFinanceServices financeServices)
        {
            _financeServices = financeServices;
        }
        // GET: api/finances
        public IQueryable<Finance> Getfinances()
        {
            return _financeServices.Getfinances();
        }

        //get
        [ResponseType(typeof(Finance))]
        public Finance Getfinance(int id)
        {
            return _financeServices.Getfinance(id);
        }

        //post
        [ResponseType(typeof(Finance))]
        public Finance Postfinance(Finance finance)
        {
            return _financeServices.Postfinance(finance);
        }

        //put
        [ResponseType(typeof(Finance))]
        public Finance Putfinance(Finance finance)
        {
            return _financeServices.Putfinance(finance);
        }

        //delete
        [ResponseType(typeof(Finance))]
        public Finance Deletefinance(int id)
        {
            return _financeServices.Deletefinance(id);
        }

        // GET: api/finances/5
        /*[ResponseType(typeof(Finance))]
        public IHttpActionResult Getfinance(int id)
        {
            Finance finance = db.finances.Find(id);
            if (finance == null)
            {
                return NotFound();
            }

            return Ok(finance);
        }*/

        // PUT: api/finances/5
        /*[ResponseType(typeof(void))]
        public IHttpActionResult Putfinance(int id, Finance finance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != finance.salary_id)
            {
                return BadRequest();
            }

            db.Entry(finance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!financeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }*/

        // POST: api/finances
        /*[ResponseType(typeof(Finance))]
        public IHttpActionResult Postfinance(Finance finance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.finances.Add(finance);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = finance.salary_id }, finance);
        }*/

        // DELETE: api/finances/5
        /*[ResponseType(typeof(Finance))]
        public IHttpActionResult Deletefinance(int id)
        {
            Finance finance = db.finances.Find(id);
            if (finance == null)
            {
                return NotFound();
            }

            db.finances.Remove(finance);
            db.SaveChanges();

            return Ok(finance);
        }*/

    }
}