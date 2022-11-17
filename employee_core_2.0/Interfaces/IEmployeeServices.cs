using employee_core_2._0.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_core_2._0.Interfaces
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int id);
        IQueryable<Employee> GetEmployeeDetails();
        Employee Postemployee(Employee employee);
        Employee Deleteemployee(int id);
        Employee Putemployee(Employee employee);
        ArrayList Getemployeeids(int id1, int id2);
    }
}
