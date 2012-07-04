namespace Kavand.DI.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BlogEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 256),
                        Abstraction = c.String(nullable: false, maxLength: 512),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        Published = c.Boolean(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false),
                        UpdatedAt = c.DateTimeOffset(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "BlogComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 512),
                        Approved = c.Boolean(nullable: false),
                        Sender_Name = c.String(nullable: false, maxLength: 32),
                        Sender_Email = c.String(nullable: false, maxLength: 64),
                        Sender_WebAddr = c.String(maxLength: 2024),
                        CreatedAt = c.DateTimeOffset(nullable: false),
                        UpdatedAt = c.DateTimeOffset(nullable: false),
                        Entry_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("BlogEntries", t => t.Entry_Id, cascadeDelete: true)
                .Index(t => t.Entry_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("BlogComments", new[] { "Entry_Id" });
            DropForeignKey("BlogComments", "Entry_Id", "BlogEntries");
            DropTable("BlogComments");
            DropTable("BlogEntries");
        }
    }
}


// Update-Database –TargetMigration:$InitialDatabase
// add-migration InitialCreate
// update-database
//see http://www.kweb.ir/blog/keyword/ef-migration
