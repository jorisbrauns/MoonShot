using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person : BaseEntity
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public int Leeftijd { get; set; }

    }
}
