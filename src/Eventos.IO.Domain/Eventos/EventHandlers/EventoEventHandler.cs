using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Eventos.Events;
using System;

namespace Eventos.IO.Domain.Eventos.EventHandlers
{
    public class EventoEventHandler :
         IHandler<EventoRegistradoEvent>,
         IHandler<EventoAtualizadoEvent>,
         IHandler<EventoExcluidoEvent>
    {
        public void Handle(EventoRegistradoEvent message)
        {
           // Enviar e-mail
        }

        public void Handle(EventoAtualizadoEvent message)
        {
            // Enviar e-mail
        }

        public void Handle(EventoExcluidoEvent message)
        {
            // Enviar e-mail
        }
    }
}
