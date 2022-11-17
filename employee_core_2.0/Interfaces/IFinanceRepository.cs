using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employee_core_2._0.Models;

namespace employee_core_2._0.Interfaces
{
   public interface IFinanceRepository
    {
        IQueryable<Finance> Getfinances();

        Finance Getfinance(int id);

        Finance Postfinance(Finance finance);

        Finance Putfinance(Finance finance);

        Finance Deletefinance(int id);
    }
}
