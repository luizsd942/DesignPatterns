namespace Patterns.Decorator.Abstratas
{
    public abstract class NotificadorDecorator : NotificadorComponent
    {
        protected NotificadorComponent notificador;
        public NotificadorDecorator(NotificadorComponent notificador)
        {
            this.notificador = notificador;
        }
        //O decorador delega todo o trabalho para o componente envolvido.
        //Comportamentos extra podem ser adicionados em decoradores concretos.
        public override void Enviar(string mensagem)
        {
            if (notificador != null)
            {
                notificador.Enviar(mensagem);
            }
        }
    }
}
