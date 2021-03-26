namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "MobileNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeModels", "MobileNumber");
        }
    }
}
