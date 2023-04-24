using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Продукти
{
    public abstract class Product
    {
        public static double count = 0;
        int number = 0;

        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }

        public Product()
        {
            count++;
        }
        public Product(string name, double quantity, double price, double tax)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Tax = tax;
        }

        public abstract void addition();

        public virtual void Count()
        {
            MessageBox.Show(count.ToString(), "Кількість", MessageBoxButtons.OK);
        }

        public virtual void Info()
        {
            addition();
            string message =
                $"Назва:            {Name}\n" +
                $"Кількість:       {Quantity} шт\n" +
                $"Ціна:              {Price}грн\n" +
                $"ПДВ:               {Tax}%\n" +
                $"Ціна з ПДВ:   {TotalPrice} грн";
            MessageBox.Show(message);
        }
        
    }


    }
