using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2ReapeatAll
{
    public class FootballTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Footballer> footballer { get; set; }
        public FootballTeam()
        {
            footballer = new Collection<Footballer>();
        }
    }
}
