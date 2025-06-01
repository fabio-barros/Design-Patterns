using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Composite
{
    internal class Cpu(double price) : IItem
    {
        public double GetPrice()
        {
            return price;
        }
    }
}
