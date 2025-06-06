//namespace Design_Patterns.Structural.Composite
//{
//    // Classes individuais sem abstração compartilhada.
//    public class KeyboardItem
//    {
//        public double Price { get; }

//        public KeyboardItem(double price)
//        {
//            Price = price;
//        }
//    }

//    public class VgaItem(double price)
//    {
//        public double Price { get; } = price;
//    }

//    public class CpuItem(double price)
//    {
//        public double Price { get; } = price;
//    }



//    public class BoxItem
//    {
//        // Ccoleção de itens diversos, não implementa uma interface/contrato comum.. (LSP)
//        // Reutilização e flexibilidade do código são comprometidas, falta polimorfismo. 
//        private List<object> items = [];

//        public void Add(object item)
//        {
//            items.Add(item);

//        }

//        public double GetTotalPrince()
//        {
//            double totalPrice = 0;

//            foreach (var item in items)
//            {
//                // Alto Acoplamento → depende de tipos específicos
//                // Verificação de tipos em tempo de execução.
//                if (item is KeyboardItem)
//                {
//                    totalPrice += ((KeyboardItem)item).Price;
//                }
//                else if (item is VgaItem)
//                {
//                    totalPrice += ((VgaItem)item).Price;
//                }
//                else if (item is CpuItem)
//                {
//                    totalPrice += ((CpuItem)item).Price;
//                }
//                else if (item is BoxItem)
//                {
//                    totalPrice += ((BoxItem)item).GetTotalPrince();
//                }
//                // OCP → Novos itens exigem alterações diretas

//            }

//            return totalPrice;
//        }
//    }


//}
