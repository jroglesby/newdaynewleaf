namespace NewDayNewLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fish", "ShadowSizeID", "dbo.ShadowSizes");
            DropForeignKey("dbo.FishTimes", "FishID", "dbo.Fish");
            DropForeignKey("dbo.FishTimes", "FishLocationID", "dbo.FishLocations");
            DropIndex("dbo.Fish", new[] { "ShadowSizeID" });
            DropIndex("dbo.FishTimes", new[] { "FishID" });
            DropIndex("dbo.FishTimes", new[] { "FishLocationID" });
            RenameColumn(table: "dbo.Fish", name: "ShadowSizeID", newName: "ShadowSize_ShadowSizeID");
            RenameColumn(table: "dbo.FishTimes", name: "FishID", newName: "Fish_FishID");
            RenameColumn(table: "dbo.FishTimes", name: "FishLocationID", newName: "FishLocation_FishLocationID");
            AddForeignKey("dbo.Fish", "ShadowSize_ShadowSizeID", "dbo.ShadowSizes", "ShadowSizeID");
            AddForeignKey("dbo.FishTimes", "Fish_FishID", "dbo.Fish", "FishID");
            AddForeignKey("dbo.FishTimes", "FishLocation_FishLocationID", "dbo.FishLocations", "FishLocationID");
            CreateIndex("dbo.Fish", "ShadowSize_ShadowSizeID");
            CreateIndex("dbo.FishTimes", "Fish_FishID");
            CreateIndex("dbo.FishTimes", "FishLocation_FishLocationID");
            DropColumn("dbo.Fish", "RarityID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fish", "RarityID", c => c.Int(nullable: false));
            DropIndex("dbo.FishTimes", new[] { "FishLocation_FishLocationID" });
            DropIndex("dbo.FishTimes", new[] { "Fish_FishID" });
            DropIndex("dbo.Fish", new[] { "ShadowSize_ShadowSizeID" });
            DropForeignKey("dbo.FishTimes", "FishLocation_FishLocationID", "dbo.FishLocations");
            DropForeignKey("dbo.FishTimes", "Fish_FishID", "dbo.Fish");
            DropForeignKey("dbo.Fish", "ShadowSize_ShadowSizeID", "dbo.ShadowSizes");
            RenameColumn(table: "dbo.FishTimes", name: "FishLocation_FishLocationID", newName: "FishLocationID");
            RenameColumn(table: "dbo.FishTimes", name: "Fish_FishID", newName: "FishID");
            RenameColumn(table: "dbo.Fish", name: "ShadowSize_ShadowSizeID", newName: "ShadowSizeID");
            CreateIndex("dbo.FishTimes", "FishLocationID");
            CreateIndex("dbo.FishTimes", "FishID");
            CreateIndex("dbo.Fish", "ShadowSizeID");
            AddForeignKey("dbo.FishTimes", "FishLocationID", "dbo.FishLocations", "FishLocationID", cascadeDelete: true);
            AddForeignKey("dbo.FishTimes", "FishID", "dbo.Fish", "FishID", cascadeDelete: true);
            AddForeignKey("dbo.Fish", "ShadowSizeID", "dbo.ShadowSizes", "ShadowSizeID", cascadeDelete: true);
        }
    }
}
