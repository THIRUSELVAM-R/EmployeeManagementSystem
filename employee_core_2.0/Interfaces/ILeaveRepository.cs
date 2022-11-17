using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employee_core_2._0.Models;

namespace employee_core_2._0.Interfaces
{
    public interface ILeaveRepository
    {
      IQueryable<Leave> Getleaves();

      Leave Getleave(int id);

      Leave Postleave(Leave leave);

      Leave Putleave(Leave leave);

      Leave Deleteleave(int id);
    }
}
