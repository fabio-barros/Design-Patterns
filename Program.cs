using Design_Patterns.Behavioral;
using Design_Patterns.Structural.Composite;

namespace Design_Patterns;

internal class Program
{

    private static void Main(string[] args)
    {
        RunMenu();
    }

    private static void RunMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Exemplo sem Composite");
            Console.WriteLine("2. Exemplo com Composite");
            Console.WriteLine("3. Exemplo sem Command");
            Console.WriteLine("4. Exemplo com Command");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    NonCompositeClient.NonCompositeExample();
                    break;
                case "2":
                    CompositeClient.CompositeExample();
                    break;
                case "3":
                    NonCommandClient.NonCommandExample();
                    break;
                case "4":
                    CommandClient.CommandExample();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    break;
            }
        }


    }




 



  
}