﻿using System.Data.Entity;

namespace AutomaticMigrations
{
    public class SuperheroContext: DbContext
    {
        public DbSet<Superhero> Superheros { get; set; }
        public DbSet<SecretIdentity> SecretIdentities { get; set; }
    }
}
