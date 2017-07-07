namespace WebGalaxy.Utils.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comentsmails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserFeedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Company = c.String(),
                        Message = c.String(),
                        Date = c.DateTime(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserMails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Message = c.String(),
                        Date = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserMails");
            DropTable("dbo.UserFeedbacks");
        }
    }
}
