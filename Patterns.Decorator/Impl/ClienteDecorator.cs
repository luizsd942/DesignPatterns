using Patterns.Decorator.Abstratas;

namespace Patterns.Decorator.Impl
{
    public class ClienteDecorator
    {
        private char _opcao;
        private NotificadorComponent notificador;
        /// <summary>
        /// A classe Cliente tem como objetivo decorar um objeto Notificador para lhe
        /// atribuir comportamentos conforme a opção informada.
        /// Princípio da responsabilidade única (SRP).
        /// </summary>
        /// <param name="notificador"></param>
        /// <param name="opcao"></param>
        public ClienteDecorator(NotificadorComponent notificador, char opcao)
        {
            this.notificador = notificador;
            _opcao = opcao;
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
