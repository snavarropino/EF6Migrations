using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeMigrationsAutomaticallyApplied
{
    public class Superhero
    {
        public Superhero()
        {
            SecretIdentities = new List<SecretIdentity>();
        }
        public int Id { get; set; }
        //[MaxLength(4)]
        public string Name { get; set; } 
        public bool IsDcSuperhero { get; set; } 
        public virtual List<SecretIdentity> SecretIdentities { get; set; }

        public override string ToString()
        {
            //var sb = new StringBuilder($"Id={Id} Name={Name} {System.Environment.NewLine}");
            var sb = new StringBuilder($"Id={Id} Name={Name} IsDcSuperhero={IsDcSuperhero}{System.Environment.NewLine}");
            foreach(var secretIdentity in SecretIdentities)
            {
                sb.AppendLine(secretIdentity.ToString());
            }
            return sb.ToString();
        }
    }
}