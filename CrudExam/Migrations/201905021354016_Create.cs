namespace CrudExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Country_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StreetCities",
                c => new
                    {
                        Street_Id = c.Guid(nullable: false),
                        City_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Street_Id, t.City_Id })
                .ForeignKey("dbo.Streets", t => t.Street_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: true)
                .Index(t => t.Street_Id)
                .Index(t => t.City_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.StreetCities", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.StreetCities", "Street_Id", "dbo.Streets");
            DropIndex("dbo.StreetCities", new[] { "City_Id" });
            DropIndex("dbo.StreetCities", new[] { "Street_Id" });
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            DropTable("dbo.StreetCities");
            DropTable("dbo.Countries");
            DropTable("dbo.Streets");
            DropTable("dbo.Cities");
        }
    }
}
