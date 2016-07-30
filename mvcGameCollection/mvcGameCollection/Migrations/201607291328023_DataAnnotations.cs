namespace mvcGameCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Games", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Games", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Rating", c => c.String());
            AlterColumn("dbo.Games", "Genre", c => c.String());
            AlterColumn("dbo.Games", "Title", c => c.String());
        }
    }
}
