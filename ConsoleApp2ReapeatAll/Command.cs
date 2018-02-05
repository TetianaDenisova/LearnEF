using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2ReapeatAll
{
    public class Command
    {
        public static void Show()
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
        }
        public static void DeleteWithTransaction()
        {
            using (var context = new City())
            {
                context.Database.Log = Console.Write;
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Footballer Ronaldo = context.Footballers.Where(x => x.Name == "Ronaldo").FirstOrDefault();
                        if (Ronaldo != null)
                        {


                            context.Footballers.Remove(Ronaldo);
                            context.SaveChanges();
                            transaction.Commit();

                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
