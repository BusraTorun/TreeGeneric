namespace TreeGeneric.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Owner = c.String(nullable: false, maxLength: 200),
                        TreeTypeId = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TreeName = c.String(nullable: false, maxLength: 200),
                        TreeDescription = c.String(),
                        TreePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlantingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Commision = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.TreeTypes", t => t.TreeTypeId, cascadeDelete: true)
                .Index(t => t.TreeTypeId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Plantings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlanterUserId = c.Int(nullable: false),
                        DonationId = c.Int(nullable: false),
                        PlantingDate = c.DateTime(nullable: false),
                        Lat = c.String(nullable: false, maxLength: 200),
                        Long = c.String(nullable: false, maxLength: 200),
                        PlantingCode = c.String(nullable: false, maxLength: 200),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donations", t => t.DonationId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.PlanterUserId, cascadeDelete: true)
                .Index(t => t.PlanterUserId)
                .Index(t => t.DonationId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 200),
                        LastName = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false, maxLength: 200),
                        IsEmailConfirmed = c.Boolean(nullable: false),
                        EmailConfirmationCode = c.String(),
                        EmailConfirmationDate = c.DateTime(),
                        Gender = c.Int(),
                        Birthdate = c.DateTime(),
                        Phone = c.String(nullable: false, maxLength: 200),
                        UserType = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(nullable: false, maxLength: 200),
                        Description = c.String(maxLength: 4000),
                        PlantingId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plantings", t => t.PlantingId, cascadeDelete: true)
                .Index(t => t.PlantingId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Description = c.String(),
                        Photo = c.String(nullable: false, maxLength: 200),
                        Capacity = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Lat = c.String(nullable: false, maxLength: 200),
                        Long = c.String(nullable: false, maxLength: 200),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TreeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Description = c.String(),
                        Photo = c.String(nullable: false, maxLength: 200),
                        TreePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlantingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Commision = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        AvailabilityCount = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .Index(t => t.RegionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donations", "TreeTypeId", "dbo.TreeTypes");
            DropForeignKey("dbo.Donations", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.TreeTypes", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Posts", "PlantingId", "dbo.Plantings");
            DropForeignKey("dbo.Plantings", "PlanterUserId", "dbo.Users");
            DropForeignKey("dbo.Plantings", "DonationId", "dbo.Donations");
            DropIndex("dbo.TreeTypes", new[] { "RegionId" });
            DropIndex("dbo.Posts", new[] { "PlantingId" });
            DropIndex("dbo.Plantings", new[] { "DonationId" });
            DropIndex("dbo.Plantings", new[] { "PlanterUserId" });
            DropIndex("dbo.Donations", new[] { "RegionId" });
            DropIndex("dbo.Donations", new[] { "TreeTypeId" });
            DropTable("dbo.TreeTypes");
            DropTable("dbo.Regions");
            DropTable("dbo.Posts");
            DropTable("dbo.Users");
            DropTable("dbo.Plantings");
            DropTable("dbo.Donations");
        }
    }
}
