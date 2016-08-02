namespace mvcGameCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 60),
                        Company = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 30),
                        HoursToBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rating = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
