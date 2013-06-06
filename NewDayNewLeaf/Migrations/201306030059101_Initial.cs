namespace NewDayNewLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fish",
                c => new
                    {
                        FishID = c.Int(nullable: false, identity: true),
                        FishName = c.String(),
                        Price = c.Int(nullable: false),
                        ShadowSizeID = c.Int(nullable: false),
                        RarityID = c.Int(nullable: false),
                        CheesySaying = c.String(),
                        Rarity_FishRarityID = c.Int(),
                    })
                .PrimaryKey(t => t.FishID)
                .ForeignKey("dbo.FishRarities", t => t.Rarity_FishRarityID)
                .ForeignKey("dbo.ShadowSizes", t => t.ShadowSizeID)
                .Index(t => t.Rarity_FishRarityID)
                .Index(t => t.ShadowSizeID);
            
            CreateTable(
                "dbo.FishRarities",
                c => new
                    {
                        FishRarityID = c.Int(nullable: false, identity: true),
                        Rarity = c.String(),
                    })
                .PrimaryKey(t => t.FishRarityID);
            
            CreateTable(
                "dbo.ShadowSizes",
                c => new
                    {
                        ShadowSizeID = c.Int(nullable: false, identity: true),
                        ShadowSizeText = c.String(),
                    })
                .PrimaryKey(t => t.ShadowSizeID);
            
            CreateTable(
                "dbo.FishTimes",
                c => new
                    {
                        FishTimeID = c.Int(nullable: false, identity: true),
                        FishID = c.Int(nullable: false),
                        FishLocationID = c.Int(nullable: false),
                        DateBegin = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        TimeBegin = c.DateTime(nullable: false),
                        TimeEnd = c.DateTime(nullable: false),
                        AdditionalInformation = c.String(),
                    })
                .PrimaryKey(t => t.FishTimeID)
                .ForeignKey("dbo.Fish", t => t.FishID, cascadeDelete: true)
                .ForeignKey("dbo.FishLocations", t => t.FishLocationID, cascadeDelete: true)
                .Index(t => t.FishID)
                .Index(t => t.FishLocationID);
            
            CreateTable(
                "dbo.FishLocations",
                c => new
                    {
                        FishLocationID = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                    })
                .PrimaryKey(t => t.FishLocationID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.FishTimes", new[] { "FishLocationID" });
            DropIndex("dbo.FishTimes", new[] { "FishID" });
            DropIndex("dbo.Fish", new[] { "ShadowSizeID" });
            DropIndex("dbo.Fish", new[] { "Rarity_FishRarityID" });
            DropForeignKey("dbo.FishTimes", "FishLocationID", "dbo.FishLocations");
            DropForeignKey("dbo.FishTimes", "FishID", "dbo.Fish");
            DropForeignKey("dbo.Fish", "ShadowSizeID", "dbo.ShadowSizes");
            DropForeignKey("dbo.Fish", "Rarity_FishRarityID", "dbo.FishRarities");
            DropTable("dbo.FishLocations");
            DropTable("dbo.FishTimes");
            DropTable("dbo.ShadowSizes");
            DropTable("dbo.FishRarities");
            DropTable("dbo.Fish");
        }
    }
}
