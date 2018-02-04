using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2ReapeatAll
{
    public class Initializator : DropCreateDatabaseAlways<City>
    {
        protected override void Seed(City context)
        {
            Footballer Ronaldo = new Footballer();
            Ronaldo.Name = "Ronaldo";
            Footballer Messi = new Footballer();
            Messi.Name = "Messi";

            FootballTeam Barselona = new FootballTeam();
            Barselona.Name = "Barselona";
            FootballTeam Real = new FootballTeam();
            Real.Name = "Real";
            Real.footballer.Add(Messi);
            Real.footballer.Add(Ronaldo);

            Messi.Teams.Add(Real);
            Messi.Teams.Add(Barselona);
            Ronaldo.Teams.Add(Real);

            context.Footballers.AddRange(new List<Footballer>() { Ronaldo, Messi });
            context.Teams.AddRange(new List<FootballTeam>() { Barselona, Real });
            context.SaveChanges();
        }
    }
}
