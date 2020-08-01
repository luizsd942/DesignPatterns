using DesignPatterns.Decorator;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - Cliente de Facebook");
            Console.WriteLine("2 - Cliente Corporativo");
            Console.WriteLine("3 - Cliente Só Celular");
            Console.WriteLine("4 - Cliente Facebook e Celular");
            Console.WriteLine();

            var opcao = Console.ReadKey();
            Console.WriteLine();

            string mensagem = "Essa é a notificação.";
            
            ClienteDecorator notificador = new ClienteDecorator(new NotificadorConcrete(), opcao.KeyChar);
            notificador.Enviar(mensagem);
        }
            
    }
}
