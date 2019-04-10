using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Eventos.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Eventos.CommandHandlers
{
    public class EventoCommandHandler : IHandler<RegistrarEventoCommand>
    {
        public void Handle(RegistrarEventoCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
