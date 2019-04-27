﻿using System;
using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Events;

namespace ConsoleTesting
{
    public class FakeBus : IBus
    {

        public void SendCommand<T>(T theEvent) where T : Command
        {
            Publish(theEvent);
        }

        public void RaiseEvent<T>(T theCommand) where T : Event
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Comando { theCommand.MessageType} Lançado");
            Publish(theCommand);
        }

        private static void Publish<T>(T message) where T : Message
        {
            var msgType = message.MessageType;
            if (msgType.Equals("DomainNotification"))
            {
                var obj = new DomainNotificationHandler();
                ((IDomainNotificationHandler<T>)obj).Handle(message);
            }

            if (msgType.Equals("RegistrarEventoCommand") ||
                msgType.Equals("AtualizarEventoCommand") ||
                msgType.Equals("ExcluirEventoCommand"))
            {
                var obj = new EventoCommandHandler(new FakeEvenoRepository(), new Fakeuow(), new FakeBus(), new DomainNotificationHandler());
                ((IHandler<T>)obj).Handle(message);

            }

            if (msgType.Equals("EventoRegistradoEvent") ||
                msgType.Equals("EventoAtualizadoEvent") ||
                msgType.Equals("EventoExcluidoEvent"))
            {
                var obj = new EventoEventHandler();
                ((IHandler<T>)obj).Handle(message);
            }

        }
    }
}