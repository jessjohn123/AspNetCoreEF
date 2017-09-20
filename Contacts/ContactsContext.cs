using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts
{
    public class ContactsContext :DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {

        }
        // Will become our table - will be named same as our property name
        public DbSet<Person> Persons { get; set; }
    }
}
