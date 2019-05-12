using System;
using System.Collections.Generic;
using Eventos.IO.Application.ViewModels;

namespace Eventos.IO.Application.Interfaces
{
    public interface IEventoAppService : IDisposable
    {
        void Registar(EventoViewModel eventoViewModel);
        IEnumerable<EventoViewModel> ObterTodos();
        IEnumerable<EventoViewModel> ObterEventoPorOrnigazador(Guid organizadorId);
        EventoViewModel ObterPorId(Guid id);
        void Atualizar(EventoViewModel eventoViewModel);
        void Excluir(Guid id);
    }
}