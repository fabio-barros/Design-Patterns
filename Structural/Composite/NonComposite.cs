namespace Design_Patterns.Structural.Composite
{
    public class KeyboardItem
    {
        public double Price { get; }

        public KeyboardItem(double price)
        {
            Price = price;
        }
    }

    public class VgaItem(double price)
    {
        public double Price { get; } = price;
    }

    public class CpuItem(double price)
    {
        public double Price { get; } = price;
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

    public class NonCompositeClient
    {
        public static void NonCompositeExample()
        {
            var package = new BoxItem();

            var box1 = new BoxItem();
            box1.Add(new KeyboardItem(100));

            var box2 = new BoxItem();
            var box3 = new BoxItem();
            box3.Add(new VgaItem(200));

            var box4 = new BoxItem();
            box4.Add(new CpuItem(300));

            box2.Add(box3);
            box2.Add(box4);

            package.Add(box1);
            package.Add(box2);

            Console.WriteLine("Método sem Composite: " + package.GetTotalPrince());
            Console.ReadKey();
        }
    }


}
