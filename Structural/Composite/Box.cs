namespace Design_Patterns.Structural.Composite
{
    public class Box : IItem
    {
        private readonly List<IItem> _items = [];

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }
        public double GetPrice()
        {
            double totalPrice = 0;

            foreach (var item in _items)
            {
                totalPrice += item.GetPrice();
            }

            return totalPrice;

            //return _items.Sum(item => item.GetPrice());
        }

    }

    public class CompositeClient
    {
        public static void CompositeExample()
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

            Console.WriteLine("Método com Composite: " + package.GetTotalPrince());
            Console.ReadKey();
        }
    }
}
