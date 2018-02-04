using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2ReapeatAll
{
    class Program
    {
        static void Main(string[] args)
        {
            using (City context = new City())
            {
                var list = context.Teams
                                  .Include("footballer")
                                  .ToList();

                foreach (var i in list)
                {
                    foreach (var item in i.footballer)
                    {
                        Console.WriteLine(i.Name + " ...  " + item.Name);

                    }
                }
                Console.WriteLine("I ended");

            }
            Console.Read();

        }
    }
}
