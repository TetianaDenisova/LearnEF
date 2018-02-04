namespace ConsoleApp2ReapeatAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToyTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Toys",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Toys", "Id", "dbo.Students");
            DropIndex("dbo.Toys", new[] { "Id" });
            DropTable("dbo.Toys");
        }
    }
}
