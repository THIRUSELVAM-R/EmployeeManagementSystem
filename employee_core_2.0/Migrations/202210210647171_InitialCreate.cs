namespace employee_core_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employees",
                c => new
                    {
                        emp_id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        contact_no = c.String(),
                        email = c.String(),
                        qualification = c.String(),
                        role = c.String(),
                        join_date = c.DateTime(nullable: false),
                        releive_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.emp_id);
            
            CreateTable(
                "dbo.finances",
                c => new
                    {
                        salary_id = c.Int(nullable: false, identity: true),
                        amount = c.Int(nullable: false),
                        date_time = c.DateTime(nullable: false),
                        emp_id = c.Int(nullable: false),
                        job_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.salary_id)
                .ForeignKey("dbo.jobdepts", t => t.job_id, cascadeDelete: true)
                .ForeignKey("dbo.employees", t => t.emp_id, cascadeDelete: true)
                .Index(t => t.emp_id)
                .Index(t => t.job_id);
            
            CreateTable(
                "dbo.jobdepts",
                c => new
                    {
                        job_id = c.Int(nullable: false, identity: true),
                        job_dept = c.String(),
                        job_name = c.String(),
                        salary_range = c.Int(nullable: false),
                        emp_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.job_id);
            
            CreateTable(
                "dbo.leaves",
                c => new
                    {
                        leave_id = c.Int(nullable: false, identity: true),
                        leave_start_date = c.DateTime(nullable: false),
                        leave_end_date = c.DateTime(nullable: false),
                        leave_type = c.String(),
                        reason = c.String(),
                        emp_id = c.Int(nullable: false),
                        job_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.leave_id)
                .ForeignKey("dbo.employees", t => t.emp_id, cascadeDelete: true)
                .ForeignKey("dbo.jobdepts", t => t.job_id, cascadeDelete: true)
                .Index(t => t.emp_id)
                .Index(t => t.job_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.leaves", "job_id", "dbo.jobdepts");
            DropForeignKey("dbo.leaves", "emp_id", "dbo.employees");
            DropForeignKey("dbo.finances", "emp_id", "dbo.employees");
            DropForeignKey("dbo.finances", "job_id", "dbo.jobdepts");
            DropIndex("dbo.leaves", new[] { "job_id" });
            DropIndex("dbo.leaves", new[] { "emp_id" });
            DropIndex("dbo.finances", new[] { "job_id" });
            DropIndex("dbo.finances", new[] { "emp_id" });
            DropTable("dbo.leaves");
            DropTable("dbo.jobdepts");
            DropTable("dbo.finances");
            DropTable("dbo.employees");
        }
    }
}
