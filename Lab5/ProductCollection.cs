using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Продукти
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public Product this[int index]
        {
            get
            {
                if (index < 0 || index >= products.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                return products[index];
            }
            set
            {
                if (index < 0 || index >= products.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                products[index] = value;
            }
        }

        public int Count => products.Count;

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(Product product)
        {
            products.Remove(product);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= products.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            products.RemoveAt(index);
        }

        public void Clear()
        {
            products.Clear();
        }

        public void PrintInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product p in products)
            {
                sb.AppendLine(p.ToString());
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
