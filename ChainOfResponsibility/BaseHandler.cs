using System;

namespace ChainOfResponsibility
{
    public abstract class BaseHandler: IHandler
    {
        protected IHandler _proximoHandler;

        public void AtribuirProximoHandler(IHandler handler)
        {
            _proximoHandler = handler;
        }

        public virtual void Atender(TiposDeProblema tipoDeProblemaDoCliente)
        {
            throw new NotImplementedException();
        }
    }
}