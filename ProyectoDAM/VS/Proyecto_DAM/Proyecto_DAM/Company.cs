using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAM
{
    class Company: Contact
    {
        String address;

        public Company()
        {

        }
        public Company(string name, string phone, string email, string address) : base(name, phone, email)
        {
            this.Address = address;
            this.Role = "Company";
        }

        public Company(int id, string name, string phone, string email, string address) : base(id, name, phone, email)
        {
            this.Address = address;
            this.Role = "Company";
        }

        public string Address { get => address; set => address = value; }
    }
}
