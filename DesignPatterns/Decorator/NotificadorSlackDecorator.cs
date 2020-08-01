using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class NotificadorSlackDecorator : NotificadorDecorator
    {
        public NotificadorSlackDecorator(NotificadorComponent notificador) : base(notificador)
        {
        }
        public override void Enviar(string mensagem)
        {
            Console.WriteLine($"Envia notificação por Slack: {mensagem}");
            base.Enviar(mensagem);
        }
        
    }
}
