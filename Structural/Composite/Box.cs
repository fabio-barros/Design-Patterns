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
}
