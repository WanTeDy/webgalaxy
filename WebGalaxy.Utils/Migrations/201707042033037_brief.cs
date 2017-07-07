namespace WebGalaxy.Utils.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class brief : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBriefs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                        Phone = c.String(),
                        AboutCompany = c.String(),
                        SiteExamples = c.String(),
                        Languages = c.String(),
                        RealizationDates = c.String(),
                        Promo = c.Boolean(nullable: false),
                        Corporative = c.Boolean(nullable: false),
                        Shop = c.Boolean(nullable: false),
                        Blog = c.Boolean(nullable: false),
                        Cutaway = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserBriefs");
        }
    }
}
