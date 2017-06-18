using System;
using System.Data.Entity;
using System.Linq;

namespace InitialCode
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
