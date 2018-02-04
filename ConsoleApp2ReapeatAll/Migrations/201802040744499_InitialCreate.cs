namespace ConsoleApp2ReapeatAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dormitories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DormitoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dormitories", t => t.DormitoryId, cascadeDelete: true)
                .Index(t => t.DormitoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DormitoryId", "dbo.Dormitories");
            DropIndex("dbo.Students", new[] { "DormitoryId" });
            DropTable("dbo.Students");
            DropTable("dbo.Dormitories");
        }
    }
}
