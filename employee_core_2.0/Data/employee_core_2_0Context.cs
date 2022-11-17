using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace employee_core_2._0.Data
{
    public class employee_core_2_0Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public employee_core_2_0Context() : base("name=employee_core_2_0Context")
        {
        }

        public System.Data.Entity.DbSet<employee_core_2._0.Models.Employee> employees { get; set; }

        public System.Data.Entity.DbSet<employee_core_2._0.Models.Jobdept> jobdepts { get; set; }

        public System.Data.Entity.DbSet<employee_core_2._0.Models.Finance> finances { get; set; }

        public System.Data.Entity.DbSet<employee_core_2._0.Models.Leave> leaves { get; set; }
    }
}
