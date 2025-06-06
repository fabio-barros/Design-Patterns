using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral
{


    public interface ICommand
    {
        void Executar();
    }

    public class Lampada
    {
        public void Ligar()
        {
            Console.WriteLine("Command -> Lampada ligada");
        }
        public void Desligar()
        {
            Console.WriteLine("Command -> Lampada desligada");
        }

        public void DiminuirBrilho()
        {
            Console.WriteLine("Command -> Diminuindo brilho da lampada");
        }
    }

    public class ControleRemoto(ICommand command)
    {
        public void Botao()
        {
            command.Executar();
        }

        public void MudarComando(ICommand command1)
        {
            command = command1;
        }
    }

    public class LigarLampadaCommand(Lampada lampada) : ICommand
    {
        public void Executar()
        {
            lampada.Ligar();
        }
    }

    public class DesligarLampadaCommand(Lampada lampada) : ICommand
    {
        public void Executar()
        {
            lampada.Desligar();
        }
    }
    public class LampadaDimCommand(Lampada lampada) : ICommand
    {
        public void Executar()
        {
            lampada.DiminuirBrilho();
        }
    }

    public class CommandClient
    {
        public static void CommandExample()
        {
            var lampada = new Lampada();
            var controleRemoto = new ControleRemoto(new LigarLampadaCommand(lampada));

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Controle Remoto da Lâmpada ===");
                Console.WriteLine("1. Ligar lâmpada");
                Console.WriteLine("2. Desligar lâmpada");
                Console.WriteLine("3. Diminuir brilho");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        controleRemoto.MudarComando(new LigarLampadaCommand(lampada));
                        controleRemoto.Botao();
                        break;
                    case "2":
                        controleRemoto.MudarComando(new DesligarLampadaCommand(lampada));
                        controleRemoto.Botao();
                        break;
                    case "3":
                        controleRemoto.MudarComando(new LampadaDimCommand(lampada));
                        controleRemoto.Botao();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
