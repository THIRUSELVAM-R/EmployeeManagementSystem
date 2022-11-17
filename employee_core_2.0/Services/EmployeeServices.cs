using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using employee_core_2._0.Interfaces;
using employee_core_2._0.Models;
using employee_core_2._0.Repository;
using employee_core_2._0.Services;

namespace employee_core_2._0.Services
{
    public class EmployeeServices:IEmployeeService
    {
        IEmployeeRepository _EmployeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }

        public Employee GetEmployee(int id)
        {
            var result = _EmployeeRepository.GetEmployee(id);
            return result;
        }

        public IQueryable<Employee> GetEmployeeDetails()
        {
             var result = _EmployeeRepository.GetEmployeeDetails();
             return result;
        }

        public Employee Postemployee(Employee employee)
        {
            var result = _EmployeeRepository.Postemployee(employee);
            return result;
        }

        public Employee Deleteemployee(int id)
        {
            var result = _EmployeeRepository.Deleteemployee(id);
            return result;
        }

        public Employee Putemployee(Employee employee)
        {
            var result = _EmployeeRepository.Putemployee(employee);
            return result;
        }

        public ArrayList Getemployeeids(int id1, int id2)
        {
            var result = _EmployeeRepository.Getemployeeids(id1, id2);
            return result;
        }
    }
}