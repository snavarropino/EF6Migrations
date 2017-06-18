using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InitialCode
{
    public class Superhero
    {
        public Superhero()
        {
            SecretIdentities = new List<SecretIdentity>();
        }
        public int Id { get; set; }        
        public string Name { get; set; }         
        public virtual List<SecretIdentity> SecretIdentities { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder($"Id={Id} Name={Name} {System.Environment.NewLine}");
            
            foreach(var secretIdentity in SecretIdentities)
            {
                sb.AppendLine(secretIdentity.ToString());
            }
            return sb.ToString();
        }
    }
}