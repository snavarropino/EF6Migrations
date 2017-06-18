using System.Collections.Generic;
using System.Data.Entity;

namespace InitialCode
{
    class DatabaseInitializer : CreateDatabaseIfNotExists<SuperheroContext>
    {
        protected override void Seed(SuperheroContext context)
        {
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
