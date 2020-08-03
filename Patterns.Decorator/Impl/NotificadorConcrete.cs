using Patterns.Decorator.Abstratas;
using System;

namespace Patterns.Decorator.Impl
{
    /// <summary>
    /// Implementação Default do Component. Deve ser a primeira classe instanciada e pode executar 
    /// alguma operação ou simplesmente não fazer nada.
    /// </summary>
    public class NotificadorConcrete : NotificadorComponent
    {
        public override void Enviar(string mensagem)
        {
            new NotImplementedException();
        }
    }
}
