using Patterns.Decorator.Abstratas;
using System;

namespace Patterns.Decorator.Impl
{
    /// <summary>
    /// Implementação Default do Component. Pode executar 
    /// alguma operação ou simplesmente não fazer nada.
    /// Será a primeira classe instanciada e a última a ser executada no invólucre
    /// </summary>
    public class NotificadorConcrete : NotificadorComponent
    {
        public override void Enviar(string mensagem)
        {
            new NotImplementedException();
        }
    }
}
