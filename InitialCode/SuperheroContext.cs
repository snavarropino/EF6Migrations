using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialCode
{
    public class SuperheroContext: DbContext
    {
        public DbSet<Superhero> Superheros { get; set; }
        public DbSet<SecretIdentity> SecretIdentities { get; set; }
    }
}
