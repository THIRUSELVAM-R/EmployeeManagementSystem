using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace employee_core_2._0.Models
{
    public class Jobdept
    {
        [Key]
        public int job_id { get; set; }

        public string job_dept { get; set; }

        public string job_name { get; set; }

        public int salary_range { get; set; }
        public int emp_id { get; set; }
    }
}