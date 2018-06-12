namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thingy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Balance", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Balance", c => c.Int(nullable: false));
        }
    }
}
