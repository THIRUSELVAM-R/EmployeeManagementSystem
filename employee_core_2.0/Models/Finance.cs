using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace employee_core_2._0.Models
{
    public class Finance
    {
        [Key]
        public int salary_id { get; set; }

        public int amount { get; set; }

        public DateTime date_time { get; set; }

        [ForeignKey("jb1")]
        public int emp_id { get; set; }

        public Employee jb1 { get; set; }

        [ForeignKey("jb")]
        public int job_id { get; set; }

        public Jobdept jb { get; set; }
    }
}