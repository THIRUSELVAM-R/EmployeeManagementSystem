using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace employee_core_2._0.Models
{
    public class Leave
    {
        [Key]
        public int leave_id { get; set; }

        public DateTime leave_start_date { get; set; }

        public DateTime leave_end_date { get; set; }

        public string leave_type { get; set; }

        public string reason { get; set; }

        [ForeignKey("empoo")]
        public int emp_id { get; set; }
        public Employee empoo { get; set; }

        [ForeignKey("empoo1")]
        public int job_id { get; set; }

        public Jobdept empoo1 { get; set; }
    }
}