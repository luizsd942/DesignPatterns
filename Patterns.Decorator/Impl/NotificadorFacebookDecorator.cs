using Patterns.Decorator.Abstratas;
using System;

namespace Patterns.Decorator.Impl
{
    public class NotificadorFacebookDecorator : NotificadorDecorator
    {
        public NotificadorFacebookDecorator(NotificadorComponent notificador) : base(notificador)
        {
        }
        public override void Enviar(string mensagem)
        {
            Console.WriteLine($"Envia notificação pelo Facebook: {mensagem}");
            base.Enviar(mensagem);
        }
        
    }
}
