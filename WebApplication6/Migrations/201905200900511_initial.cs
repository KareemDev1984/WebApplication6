namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        LogIdentity = c.String(nullable: false, maxLength: 128),
                        ErrorMessage = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        ApplicationName = c.String(),
                    })
                .PrimaryKey(t => t.LogIdentity);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logs");
        }
    }
}
