namespace NewDayNewLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FishLocationID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FishTimes", "FishLocation_FishLocationID", "dbo.FishLocations");
            DropIndex("dbo.FishTimes", new[] { "FishLocation_FishLocationID" });
            RenameColumn(table: "dbo.FishTimes", name: "FishLocation_FishLocationID", newName: "FishLocationID");
            AddForeignKey("dbo.FishTimes", "FishLocationID", "dbo.FishLocations", "FishLocationID", cascadeDelete: true);
            CreateIndex("dbo.FishTimes", "FishLocationID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.FishTimes", new[] { "FishLocationID" });
            DropForeignKey("dbo.FishTimes", "FishLocationID", "dbo.FishLocations");
            RenameColumn(table: "dbo.FishTimes", name: "FishLocationID", newName: "FishLocation_FishLocationID");
            CreateIndex("dbo.FishTimes", "FishLocation_FishLocationID");
            AddForeignKey("dbo.FishTimes", "FishLocation_FishLocationID", "dbo.FishLocations", "FishLocationID");
        }
    }
}
