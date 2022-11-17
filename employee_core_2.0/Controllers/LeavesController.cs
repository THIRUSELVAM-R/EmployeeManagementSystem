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
    public class LeavesController : ApiController
    {
        ILeaveServices _leaveServices;

        public LeavesController(ILeaveServices leaveServices)
        {
            _leaveServices = leaveServices;
        }
        private employee_core_2_0Context db = new employee_core_2_0Context();

        // GET: api/leaves
        public IQueryable<Leave> Getleaves()
        {
            return _leaveServices.Getleaves();
        }

        //get
        [ResponseType(typeof(Leave))]
        public Leave Getleave(int id)
        {
            return _leaveServices.Getleave(id);
        }

        //post
        [ResponseType(typeof(Leave))]
        public Leave Postleave(Leave leave)
        {
            return _leaveServices.Postleave(leave);
        }

        //put
        [ResponseType(typeof(void))]
        public Leave Putleave(Leave leave)
        {
            return _leaveServices.Putleave(leave);
        }

        //delete
        [ResponseType(typeof(Leave))]
        public Leave Deleteleave(int id)
        {
            return _leaveServices.Deleteleave(id);
        }
        // GET: api/leaves/5
        /*[ResponseType(typeof(Leave))]
        public IHttpActionResult Getleave(int id)
        {
            Leave leave = db.leaves.Find(id);
            if (leave == null)
            {
                return NotFound();
            }

            return Ok(leave);
        }*/

        // PUT: api/leaves/5
        /*[ResponseType(typeof(void))]
        public IHttpActionResult Putleave(int id, Leave leave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leave.leave_id)
            {
                return BadRequest();
            }

            db.Entry(leave).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!leaveExists(id))
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

        // POST: api/leaves
        /*[ResponseType(typeof(Leave))]
        public IHttpActionResult Postleave(Leave leave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.leaves.Add(leave);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = leave.leave_id }, leave);
        }*/

        // DELETE: api/leaves/5
        /*[ResponseType(typeof(Leave))]
        public IHttpActionResult Deleteleave(int id)
        {
            Leave leave = db.leaves.Find(id);
            if (leave == null)
            {
                return NotFound();
            }

            db.leaves.Remove(leave);
            db.SaveChanges();

            return Ok(leave);
        }*/

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool leaveExists(int id)
        {
            return db.leaves.Count(e => e.leave_id == id) > 0;
        }
    }
}