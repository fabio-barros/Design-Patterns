namespace Design_Patterns.Structural.Composite
{

    public interface IItemComponent
    {
        double GetPrice();
    }

    internal class CompositeKeyboardItem(double price) : IItemComponent
    {
        public double GetPrice()
        {
            return price;
        }
    }

    internal class CompositeItemVga(double price) : IItemComponent
    {
        public double GetPrice()
        {
            return price;
        }
    }

    internal class CompositeItemCpu(double price) : IItemComponent
    {
        public double GetPrice()
        {
            return price;
        }
    }
    
    public class CompositeBox : IItemComponent
    {
        private readonly List<IItemComponent> _items = [];

        public void AddItem(IItemComponent itemComponent)
        {
            _items.Add(itemComponent);
        }
        public double GetPrice()
        {
            double totalPrice = 0;

            foreach (var item in _items)
            {
                totalPrice += item.GetPrice();
            }

            return totalPrice;

            //return _items.Sum(itemComponent => itemComponent.GetPrice());
        }

    }

    public class CompositeClient
    {
        public static void CompositeExample()
        {
            var package = new CompositeBox();

            var box1 = new CompositeBox();
            box1.AddItem(new CompositeKeyboardItem(100));

            var box2 = new CompositeBox();

            var box3 = new CompositeBox();
            box3.AddItem(new CompositeItemVga(200));

            var box4 = new CompositeBox();
            box4.AddItem(new CompositeItemCpu(400));

            box2.AddItem(box3);
            box2.AddItem(box4);

            package.AddItem(box1);
            package.AddItem(box2);

            Console.WriteLine("Método com Composite: " + package.GetPrice());
            Console.ReadKey();
        }
    }
}
