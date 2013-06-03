namespace NewDayNewLeaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlathersSaying : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fish", "BlathersInfo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fish", "BlathersInfo");
        }
    }
}
