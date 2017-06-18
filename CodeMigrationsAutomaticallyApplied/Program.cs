using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMigrationsAutomaticallyApplied
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DatabaseInitializer());

            using (var ctx = new SuperheroContext())
            {
                var superheros = ctx.Superheros.ToList();

                foreach (var superhero in superheros)
                {
                    Console.WriteLine(superhero.ToString());
                }
            }
        }
    }
}
