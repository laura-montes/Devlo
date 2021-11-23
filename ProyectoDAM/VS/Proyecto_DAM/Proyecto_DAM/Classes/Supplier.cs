using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAM.Classes
{
    class Supplier
    {
        private int code;
        private string name, description;

        public Supplier(int code, string name, string description)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
