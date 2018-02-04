namespace ConsoleApp2ReapeatAll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footballers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FootballTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FootballTeamFootballers",
                c => new
                    {
                        FootballTeam_Id = c.Int(nullable: false),
                        Footballer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FootballTeam_Id, t.Footballer_Id })
                .ForeignKey("dbo.FootballTeams", t => t.FootballTeam_Id, cascadeDelete: true)
                .ForeignKey("dbo.Footballers", t => t.Footballer_Id, cascadeDelete: true)
                .Index(t => t.FootballTeam_Id)
                .Index(t => t.Footballer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FootballTeamFootballers", "Footballer_Id", "dbo.Footballers");
            DropForeignKey("dbo.FootballTeamFootballers", "FootballTeam_Id", "dbo.FootballTeams");
            DropIndex("dbo.FootballTeamFootballers", new[] { "Footballer_Id" });
            DropIndex("dbo.FootballTeamFootballers", new[] { "FootballTeam_Id" });
            DropTable("dbo.FootballTeamFootballers");
            DropTable("dbo.FootballTeams");
            DropTable("dbo.Footballers");
        }
    }
}
