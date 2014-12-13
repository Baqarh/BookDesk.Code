namespace BuySellOldBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBookStateDT : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Book", "State", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Book", "State", c => c.Int(nullable: false));
        }
    }
}
