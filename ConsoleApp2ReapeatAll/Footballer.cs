using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp2ReapeatAll
{
    public class Footballer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FootballTeam> Teams { get; set; }
        public Footballer()
        {
            Teams = new Collection<FootballTeam>();
        }
    }
}