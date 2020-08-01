using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class NotificadorTeamsDecorator : NotificadorDecorator
    {
        public NotificadorTeamsDecorator(NotificadorComponent notificador) : base(notificador)
        {
        }
        public override void Enviar(string mensagem)
        {
            Console.WriteLine($"Envia notificação por Teams: {mensagem}");
            base.Enviar(mensagem);
        }
        
    }
}
