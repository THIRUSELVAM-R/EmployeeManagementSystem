using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using employee_core_2._0.Interfaces;
using employee_core_2._0.Models;
using employee_core_2._0.Repository;
using employee_core_2._0.Services;

namespace employee_core_2._0.Services
{
    public class FinanceServices:IFinanceServices
    {
        IFinanceRepository _financeRepository;

        public FinanceServices(IFinanceRepository financeRepository)
        {
            _financeRepository = financeRepository;
        }

        public IQueryable<Finance> Getfinances()
        {
            var result = _financeRepository.Getfinances();
            return result;
        }

        public Finance Getfinance(int id)
        {
            var result = _financeRepository.Getfinance(id);
            return result;
        }

        public Finance Postfinance(Finance finance)
        {
            var result = _financeRepository.Postfinance(finance);
            return result;
        }

        public Finance Putfinance(Finance finance)
        {
            var result = _financeRepository.Putfinance(finance);
            return result;
        }

        public Finance Deletefinance(int id)
        {
            var result = _financeRepository.Deletefinance(id);
            return result;
        }
    }
}