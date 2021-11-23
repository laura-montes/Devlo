using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAM.Classes
{
    class Product
    {
        private int id, code, category, supplier, stock, units;
        private string name, description;
        private double sell_price, supplier_price;

        public Product()
        {

        }

        public Product(int id, int code, int category, int supplier, int stock, string name, string description, double sell_price, double supplier_price)
        {
            this.Code = code;
            this.Category = category;
            this.Supplier = supplier;
            this.Stock = stock;
            this.Name = name;
            this.Description = description;
            this.Sell_price = sell_price;
            this.Supplier_price = supplier_price;
        }

        public Product(int category, int supplier, int stock, string name, string description, double sell_price, double supplier_price)
        {
            this.Category = category;
            this.Supplier = supplier;
            this.Stock = stock;
            this.Name = name;
            this.Description = description;
            this.Sell_price = sell_price;
            this.Supplier_price = supplier_price;
        }

        public int Id { get => id; set => id = value; }
        public int Code { get => code; set => code = value; }
        public int Category { get => category; set => category = value; }
        public int Supplier { get => supplier; set => supplier = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Sell_price { get => sell_price; set => sell_price = value; }
        public double Supplier_price { get => supplier_price; set => supplier_price = value; }
        public int Units { get => units; set => units = value; }
       
    }
}
