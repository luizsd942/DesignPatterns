using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
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
