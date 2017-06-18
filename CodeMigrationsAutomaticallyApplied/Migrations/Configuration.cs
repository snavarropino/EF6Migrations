using System.Collections.Generic;

namespace CodeMigrationsAutomaticallyApplied.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeMigrationsAutomaticallyApplied.SuperheroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CodeMigrationsAutomaticallyApplied.SuperheroContext";
        }

        protected override void Seed(CodeMigrationsAutomaticallyApplied.SuperheroContext context)
        {
            if (context.Superheros.Any())
                return;
            // Seed code here
            var superman = new Superhero()
            {
                Name = "Superman",
                SecretIdentities = new List<SecretIdentity>()
                {
                    new SecretIdentity()
                    {
                        Identity="Clark"
                    },
                    new SecretIdentity()
                    {
                        Identity="Ken"
                    }
                }
            };

            var memto = new Superhero()
            {
                Name = "Memto"
            };


            context.Superheros.AddRange(new List<Superhero>() { superman, memto });
            context.SaveChanges();
        }
    }
}
