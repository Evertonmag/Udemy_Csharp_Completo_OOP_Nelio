using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Pensao
    {
        public string Name { get; set; }
        public string EMail { get; set; }

        public Pensao(string name, string eMail)
        {
            Name = name;
            EMail = eMail;
        }

        public override string ToString()
        {
            return $"{Name}, {EMail}";
        }

    }
}
