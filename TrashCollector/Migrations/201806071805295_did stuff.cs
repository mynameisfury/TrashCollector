namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class didstuff : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CustomerUsers", newName: "Customers");
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.WorkerUsers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WorkerUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Workers");
            RenameTable(name: "dbo.Customers", newName: "CustomerUsers");
        }
    }
}
