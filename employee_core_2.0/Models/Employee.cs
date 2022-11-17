using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace employee_core_2._0.Models
{
    public class Employee
    {
        [Key]
        public int emp_id { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public string contact_no { get; set; }

        public string email { get; set; }

        public string qualification { get; set; }

        public string role { get; set; }

        public DateTime join_date { get; set; }

        public DateTime releive_date { get; set; }
    }
}