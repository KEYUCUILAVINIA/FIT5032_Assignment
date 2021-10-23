namespace FIT5032_2021S2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookEvent : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BookEvents");
            AddPrimaryKey("dbo.BookEvents", new[] { "StoreEventId", "UserId" });
            DropColumn("dbo.BookEvents", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookEvents", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.BookEvents");
            AddPrimaryKey("dbo.BookEvents", "Id");
        }
    }
}
