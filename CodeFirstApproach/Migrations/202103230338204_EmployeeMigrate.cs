namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeMigrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeModels",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        EmpSalary = c.Int(nullable: false),
                        Designation = c.String(),
                        EmailId = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeModels");
        }
    }
}
