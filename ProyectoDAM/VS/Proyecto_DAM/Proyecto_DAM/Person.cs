using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAM
{
    class Person: Contact
    {
        string surnames, role;

        public Person(string surnames, string role): base(id,name, phone, email)
        {
            this.surnames = surnames;
            this.role = role;
        }
    }
}
