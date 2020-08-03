using Patterns.Decorator.Abstratas;
using System;

namespace Patterns.Decorator.Impl
{
    public class NotificadorSMSDecorator : NotificadorDecorator
    {
        public NotificadorSMSDecorator(NotificadorComponent notificador) : base(notificador)
        {
        }
        public override void Enviar(string mensagem)
        {
            Console.WriteLine($"Envia notificação por SMS: {mensagem}");
            base.Enviar(mensagem);
        }
        
    }
}
