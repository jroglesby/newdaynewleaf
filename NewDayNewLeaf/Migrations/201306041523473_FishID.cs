namespace NewDayNewLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FishID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FishTimes", "Fish_FishID", "dbo.Fish");
            DropIndex("dbo.FishTimes", new[] { "Fish_FishID" });
            RenameColumn(table: "dbo.FishTimes", name: "Fish_FishID", newName: "FishID");
            AddForeignKey("dbo.FishTimes", "FishID", "dbo.Fish", "FishID", cascadeDelete: true);
            CreateIndex("dbo.FishTimes", "FishID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.FishTimes", new[] { "FishID" });
            DropForeignKey("dbo.FishTimes", "FishID", "dbo.Fish");
            RenameColumn(table: "dbo.FishTimes", name: "FishID", newName: "Fish_FishID");
            CreateIndex("dbo.FishTimes", "Fish_FishID");
            AddForeignKey("dbo.FishTimes", "Fish_FishID", "dbo.Fish", "FishID");
        }
    }
}
