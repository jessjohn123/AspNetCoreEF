using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts
{
    public class Person
    {
        public int PersonId { get; set; } // Unique Identifier and will map to our primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
