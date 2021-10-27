using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAM
{
    class Customer: Contact
    {
        String surnames;

        public Customer()
        {

        }
        public Customer(string name, string surnames, string phone, string email) : base(name, phone, email)
        {
            this.Surnames = surnames;
            this.Role = "Customer";
        }

        public Customer(int id, string name, string surnames, string phone, string email) : base(id, name, phone, email)
        {
            this.Surnames = surnames;
            this.Role = "Customer";
        }

        public string Surnames { get => surnames; set => surnames = value; }
    }
}
