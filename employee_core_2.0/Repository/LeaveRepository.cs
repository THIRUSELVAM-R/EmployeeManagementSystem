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
    public class LeaveRepository : ILeaveRepository
    {
        private employee_core_2_0Context db = new employee_core_2_0Context();

        public IQueryable<Leave> Getleaves()
        {
            return db.leaves;
        }

        [ResponseType(typeof(Leave))]
        public Leave Getleave(int id)
        {
            Leave leave = db.leaves.Find(id);
            if (leave == null)
            {
                throw new Exception("not found");
            }
            return leave;
        }

        [ResponseType(typeof(Leave))]
        public Leave Postleave(Leave leave)
        {
            try
            {
                db.leaves.Add(leave);
                db.SaveChanges();
                return leave;
            }
            catch
            {
                throw new Exception("not found");
            }
        }

        [ResponseType(typeof(void))]
        public Leave Putleave(Leave leave)
        {
            if (leave.leave_id<=0)
            {
                throw new Exception("not found");
            }

            db.Entry(leave).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("not found");
            }

            return leave;
        }

        [ResponseType(typeof(Leave))]
        public Leave Deleteleave(int id)
        {
            Leave leave = db.leaves.Find(id);
            if (leave == null)
            {
                throw new Exception("not found");
            }

            db.leaves.Remove(leave);
            db.SaveChanges();
            return leave;
        }
    }
}