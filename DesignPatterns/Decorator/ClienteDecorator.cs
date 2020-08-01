using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class ClienteDecorator
    {
        private char _opcao;
        private NotificadorComponent notificador;
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public ClienteDecorator(NotificadorComponent notificador, char opcao)
        {
            this.notificador = notificador;
            this._opcao = opcao;
        }
        public void Enviar(string mensagem)
        {
            switch (_opcao)
            {
                case '1':
                    var fb = new NotificadorFacebookDecorator(notificador);
                    fb.Enviar(mensagem);
                    break;
                case '2':
                    var teams = new NotificadorTeamsDecorator(notificador);
                    var slack = new NotificadorSlackDecorator(teams);
                    slack.Enviar(mensagem);
                    break;
                case '3':
                    var sms = new NotificadorSMSDecorator(notificador);
                    sms.Enviar(mensagem);
                    break;
                case '4':
                    fb = new NotificadorFacebookDecorator(notificador);
                    sms = new NotificadorSMSDecorator(fb);
                    sms.Enviar(mensagem);
                    break;
            }
        }
    }
}
