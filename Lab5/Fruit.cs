using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Продукти
{
    public class Fruit : Product
    {
        public string type = "Фрукти";
        public Fruit() { }
        public Fruit(string name, double quantity, double price, double tax) : base(name, quantity, price, tax)
        {
         
        }

        ~Fruit()
        {
            MessageBox.Show($"видалено об'єкт {count}");
            count--;
        }
        public override void addition()
        {
            TotalPrice = Price * Quantity * (1 + Tax / 100) * 1.1; // adding an additional 10% markup for fruits
        }

        public override void Info()
        {
            base.Info(); // викликаємо базову реалізацію методу Info з класу Product
            // додаткові дії для класу Fruit
        }
        public void Dispose()
        {
            this.Dispose();
        }
    }
}
