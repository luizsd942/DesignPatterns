using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
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
