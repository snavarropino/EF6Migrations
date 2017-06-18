using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialCode
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public string  Identity { get; set; }

        public Superhero Superhero { get; set; }

        public override string ToString()
        {
            return ($"   Secret identity: Id={Id} Identity={Identity}");
        }
    }
}
