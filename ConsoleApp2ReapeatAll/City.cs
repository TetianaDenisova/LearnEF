namespace ConsoleApp2ReapeatAll
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class City : DbContext
    {
        public City()
             : base("main")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Dormitory> Dormitorys { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<FootballTeam> Teams { get; set; }
    }


}