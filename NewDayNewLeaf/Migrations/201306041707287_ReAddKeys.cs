namespace NewDayNewLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReAddKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fish", "Rarity_FishRarityID", "dbo.FishRarities");
            DropForeignKey("dbo.Fish", "ShadowSize_ShadowSizeID", "dbo.ShadowSizes");
            DropIndex("dbo.Fish", new[] { "Rarity_FishRarityID" });
            DropIndex("dbo.Fish", new[] { "ShadowSize_ShadowSizeID" });
            RenameColumn(table: "dbo.Fish", name: "Rarity_FishRarityID", newName: "FishRarityID");
            RenameColumn(table: "dbo.Fish", name: "ShadowSize_ShadowSizeID", newName: "ShadowSizeID");
            AddForeignKey("dbo.Fish", "FishRarityID", "dbo.FishRarities", "FishRarityID", cascadeDelete: true);
            AddForeignKey("dbo.Fish", "ShadowSizeID", "dbo.ShadowSizes", "ShadowSizeID", cascadeDelete: true);
            CreateIndex("dbo.Fish", "FishRarityID");
            CreateIndex("dbo.Fish", "ShadowSizeID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Fish", new[] { "ShadowSizeID" });
            DropIndex("dbo.Fish", new[] { "FishRarityID" });
            DropForeignKey("dbo.Fish", "ShadowSizeID", "dbo.ShadowSizes");
            DropForeignKey("dbo.Fish", "FishRarityID", "dbo.FishRarities");
            RenameColumn(table: "dbo.Fish", name: "ShadowSizeID", newName: "ShadowSize_ShadowSizeID");
            RenameColumn(table: "dbo.Fish", name: "FishRarityID", newName: "Rarity_FishRarityID");
            CreateIndex("dbo.Fish", "ShadowSize_ShadowSizeID");
            CreateIndex("dbo.Fish", "Rarity_FishRarityID");
            AddForeignKey("dbo.Fish", "ShadowSize_ShadowSizeID", "dbo.ShadowSizes", "ShadowSizeID");
            AddForeignKey("dbo.Fish", "Rarity_FishRarityID", "dbo.FishRarities", "FishRarityID");
        }
    }
}
