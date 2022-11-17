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

namespace employee_core_2._0.Repository
{
    public class EmployeeRepository :ApiController, IEmployeeRepository
    {
        private employee_core_2_0Context db = new employee_core_2_0Context();

        //get/id
        [ResponseType(typeof(Employee))]
        public Employee GetEmployee(int id)
        {
            Employee employee = db.employees.Find(id);
            if (employee == null)
            {
                throw new Exception("not found");
            }
            return employee;
        }

        //get
        public IQueryable<Employee> GetEmployeeDetails()
        {
            return db.employees;
        }

        //post
        [ResponseType(typeof(Employee))]
        public Employee Postemployee(Employee employee)
        {
          try
            {
                db.employees.Add(employee);
                db.SaveChanges();
                return employee;
            }
            catch
            {
                throw new Exception("not found");
            }
        }

        //delete

        [ResponseType(typeof(Employee))]
        public Employee Deleteemployee(int id)
        {
            Employee employee = db.employees.Find(id);
            if (employee == null)
            {
                throw new Exception("not found");
            }

            db.employees.Remove(employee);
            db.SaveChanges();

            return employee;
        }

        //put
        [ResponseType(typeof(Employee))]
        public Employee Putemployee(Employee employee)
        {
            if (employee.emp_id<=0)
            {
                throw new Exception("not found");
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("not found");
            }

            return employee;
        }


        [ResponseType(typeof(ArrayList))]
        public ArrayList Getemployeeids(int id1, int id2)
        {
            Employee employee = db.employees.Find(id1);
            Jobdept jobdept = db.jobdepts.Find(id2);
            if (employee == null)
            {
                throw new Exception("not found");
            }
            ArrayList list1 = new ArrayList();
            list1.Add(employee.name);
            list1.Add(employee.emp_id);
            list1.Add(jobdept.job_id);
            list1.Add(jobdept.job_name);
            list1.Add(jobdept.salary_range);
            return list1;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool employeeExists(int id)
        {
            return db.employees.Count(e => e.emp_id == id) > 0;
        }

    }
}