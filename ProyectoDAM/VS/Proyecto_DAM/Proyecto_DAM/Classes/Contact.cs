using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAM
{
    class Contact
    {
        private int id;
        private String name;
        private String phone;
        private String email;
        private String role;

        public Contact()
        {

        }

        public Contact(int id, string name, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.role = null;
        }

        public Contact(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.role = null;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Role { get => role; set => role = value; }
    }
}
