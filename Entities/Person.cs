using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

    }
}
