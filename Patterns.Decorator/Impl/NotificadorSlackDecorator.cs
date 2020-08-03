using Patterns.Decorator.Abstratas;
using System;

namespace Patterns.Decorator.Impl
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
