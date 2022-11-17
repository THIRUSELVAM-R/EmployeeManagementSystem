using System;
using System.Collections;
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
    public class EmployeesController : ApiController
    {
        IEmployeeService _EmployeeServices;

        public EmployeesController(IEmployeeService employeeServices)
        {
            _EmployeeServices = employeeServices;
        }

        //get
        [ResponseType(typeof(Employee))]

        public Employee GetEmployee(int id)
        {
            return _EmployeeServices.GetEmployee(id);
        }
        private employee_core_2_0Context db = new employee_core_2_0Context();

        // GET: api/employees
        public IQueryable<Employee> Getemployees()
        {
            return _EmployeeServices.GetEmployeeDetails();
        }

        //post
        [ResponseType(typeof(Employee))]
        public Employee Postemployee(Employee employee)
        {
            return _EmployeeServices.Postemployee(employee);
        }

        //delete
        [ResponseType(typeof(Employee))]
        public Employee Deleteemployee(int id)
        {
            return _EmployeeServices.Deleteemployee(id);
        }

        //put
        [ResponseType(typeof(Employee))]
        public Employee Putemployee(Employee employee)
        {
            return _EmployeeServices.Putemployee(employee);
        }

        [Route("api/Employees/Getemployeeids/{id1}/{id2}")]
        [ResponseType(typeof(ArrayList))]
        public ArrayList Getemployeeids(int id1, int id2)
        {
            return _EmployeeServices.Getemployeeids(id1, id2);
        }

        // GET: api/employees/5
        /* [ResponseType(typeof(Employee))]
         public IHttpActionResult Getemployee(int id)
         {
             Employee employee = db.employees.Find(id);
             if (employee == null)
             {
                 return NotFound();
             }

             return Ok(employee);
         }*/

        // PUT: api/employees/5

        /* [ResponseType(typeof(void))]
         public IHttpActionResult Putemployee(int id, Employee employee)
         {
             if (!ModelState.IsValid)
             {
                 return BadRequest(ModelState);
             }

             if (id != employee.emp_id)
             {
                 return BadRequest();
             }

             db.Entry(employee).State = EntityState.Modified;

             try
             {
                 db.SaveChanges();
             }
             catch (DbUpdateConcurrencyException)
             {
                 if (!employeeExists(id))
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


        // POST: api/employees
        /*[ResponseType(typeof(Employee))]
        public IHttpActionResult Postemployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.employees.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.emp_id }, employee);
        }*/

        // DELETE: api/employees/5
        /*[ResponseType(typeof(Employee))]
        public IHttpActionResult Deleteemployee(int id)
        {
            Employee employee = db.employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            } 

            db.employees.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }*/
    }
}