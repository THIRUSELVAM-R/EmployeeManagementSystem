using employee_core_2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_core_2._0.Interfaces
{
    public interface IFinanceServices
    {
        IQueryable<Finance> Getfinances();

        Finance Getfinance(int id);

        Finance Postfinance(Finance finance);

        Finance Putfinance(Finance finance);

        Finance Deletefinance(int id);
    }
}
