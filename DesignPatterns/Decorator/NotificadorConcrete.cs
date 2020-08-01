using System;

namespace DesignPatterns.Decorator
{
    public class NotificadorConcrete : NotificadorComponent
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine($"Essa é a forma default de Notificar... Por Email: {mensagem}");
        }
    }
}
