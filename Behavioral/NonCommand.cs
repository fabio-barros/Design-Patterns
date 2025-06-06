using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral
{
    //Receiver
    public class LampadaNonCommand
    {
        public void Ligar()
        {
            Console.WriteLine("Luz ligada");
        }
        public void Desligar()
        {
            Console.WriteLine("Light desligada");
        }
    }

    //Invoker
    public class ControleRemotoNonCommand
    {
        private LampadaNonCommand _lampadaNonCommand;
        public ControleRemotoNonCommand(LampadaNonCommand lampadaNonCommand)
        {
            _lampadaNonCommand = lampadaNonCommand;
        }
        public void Botao(bool ligar)
        {
            if (ligar)
            {
                _lampadaNonCommand.Ligar();
            }
            else
            {
                _lampadaNonCommand.Desligar();
            }
        }
    }

    public class NonCommandClient
    {
        public static void NonCommandExample()
        {
            var controleRemoto = new ControleRemotoNonCommand(new LampadaNonCommand());
            controleRemoto.Botao(true);
            controleRemoto.Botao(false);

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }
}
