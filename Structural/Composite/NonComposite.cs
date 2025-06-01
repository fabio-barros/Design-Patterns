using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Composite
{
    public class KeyboardItem(double price)
    {
        public double Price { get; set; } = price;
    }

    public class VgaItem(double price)
    {
        public double Price { get; set; } = price;
    }

    public class CpuItem(double price)
    {
        public double Price { get; set; } = price;
    }

    public class BoxItem
    {
        private List<object> items = [];

        public void Add(object item)
        {
            items.Add(item);

        }

        public double GetTotalPrince()
        {
            double totalPrice = 0;

            foreach (var item in items)
            {
                if (item is KeyboardItem)
                {
                    totalPrice += ((KeyboardItem)item).Price;
                }
                else if (item is VgaItem)
                {
                    totalPrice += ((VgaItem)item).Price;
                }
                else if (item is CpuItem)
                {
                    totalPrice += ((CpuItem)item).Price;
                }
                else if (item is BoxItem)
                {
                    totalPrice += ((BoxItem)item).GetTotalPrince();
                }
            }

            return totalPrice;
        }
    }
}
