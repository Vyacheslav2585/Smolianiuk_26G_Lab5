using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Продукти
{
    public class Vegetable : Product
    {
        public string type = "Овочі";
        public Vegetable() { }
        public Vegetable(string name, double quantity, double price, double tax) : base(name, quantity, price, tax)
        {
            
        }
        ~Vegetable()
        {
            MessageBox.Show($"видалено об'єкт {count}");
            count--;
        }
        public override void addition()
        {
            TotalPrice = Price * Quantity * (1 + Tax / 100);
        }
        public override void Info()
        {
            base.Info();
            // додаткові дії для класу Vegetable
        }
    }
}
