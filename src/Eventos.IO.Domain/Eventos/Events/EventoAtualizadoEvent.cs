using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Eventos.Events
{
    public abstract class EventoAtualizadoEvent : BaseEventoEvent
    {
        public EventoAtualizadoEvent(
            Guid id,
            string nome,
            string descCurta,
            string descLonga,
            DateTime dataInicio,
            DateTime dataFim,
            bool gratuito,
            decimal valor,
            bool online,
            string nomeEmpresa)
        {
            Id = id;
            DescricaoCurta = descCurta;
            DescricaoLonga = descLonga;
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;


        }
    }
}
