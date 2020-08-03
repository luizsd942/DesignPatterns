using Patterns.Decorator.Abstratas;
using System;

namespace Patterns.Decorator.Impl
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
