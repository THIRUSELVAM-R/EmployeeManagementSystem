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
    public class JobdeptsController : ApiController
    {
        IJobdeptServices _jobdeptServices;
        public JobdeptsController(IJobdeptServices jobdeptServices)
        {
            _jobdeptServices = jobdeptServices;
        }

        //get
        [ResponseType(typeof(Jobdept))]
        public Jobdept GetJobdept(int id)
        {
            return _jobdeptServices.GetJobdept(id);
        }

        // GET: api/jobdepts
        public IQueryable<Jobdept> Getjobdepts()
        {
            return _jobdeptServices.Getjobdepts();
        }

        //post
        [ResponseType(typeof(Jobdept))]
        public Jobdept Postjobdept(Jobdept jobdept)
        {
            return _jobdeptServices.Postjobdept(jobdept);
        }

        //put

        [ResponseType(typeof(Jobdept))]
        public Jobdept Putjobdept( Jobdept jobdept)
        {
            return _jobdeptServices.Putjobdept( jobdept);
        }

        //delete

        [ResponseType(typeof(Jobdept))]
        public Jobdept Deletejobdept(int id)
        {
            return _jobdeptServices.Deletejobdept(id);
        }

        [Route("api/jobdepts/Getjobdeptsal/{sal}")]
        [ResponseType(typeof(Dictionary<int, int>))]
        public Dictionary<int, int> Getjobdeptsal(int sal)
        {
            return _jobdeptServices.Getjobdeptsal(sal);
        }
         
        [Route("api/jobdepts/Getfinallsal/{job_id}")]
        [ResponseType(typeof(long))]

        public long Getfinallsal(int job_id)
        {
            return _jobdeptServices.Getfinallsal(job_id);
        }

        [Route("api/jobdepts/GetSalrangeFilter/{value}")]

        public IQueryable<Jobdept> GetSalrangeFilter(int value)
        {
            return _jobdeptServices.GetSalrangeFilter(value);
        }

        // GET: api/jobdepts/5
        /* [ResponseType(typeof(Jobdept))]
         public IHttpActionResult Getjobdept(int id)
         {
             Jobdept jobdept = db.jobdepts.Find(id);
             if (jobdept == null)
             {
                 return NotFound();
             }

             return Ok(jobdept);
         }*/

        // PUT: api/jobdepts/5
        /*[ResponseType(typeof(void))]
        public IHttpActionResult Putjobdept(int id, Jobdept jobdept)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jobdept.job_id)
            {
                return BadRequest();
            }

            db.Entry(jobdept).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!jobdeptExists(id))
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

        // POST: api/jobdepts
        /*[ResponseType(typeof(Jobdept))]
        public IHttpActionResult Postjobdept(Jobdept jobdept)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.jobdepts.Add(jobdept);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = jobdept.job_id }, jobdept);
        }*/

        // DELETE: api/jobdepts/5
        /*[ResponseType(typeof(Jobdept))]
        public IHttpActionResult Deletejobdept(int id)
        {
            Jobdept jobdept = db.jobdepts.Find(id);
            if (jobdept == null)
            {
                return NotFound();
            }

            db.jobdepts.Remove(jobdept);
            db.SaveChanges();

            return Ok(jobdept);
        }*/

    }
}