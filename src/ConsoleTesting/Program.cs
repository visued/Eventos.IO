using System;
using ConsoleTesting;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Eventos.Commands;


class Program
{
    static void Main(string[] args)
    {
        var bus = new FakeBus();
        // Registro com sucesso!
        var cmd = new RegistrarEventoCommand("DevX", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true, 0,
            true, "Empresa");
        Inicio(cmd);
        bus.SendCommand(cmd);
        Fim(cmd);

        // Registro com erros
        cmd = new RegistrarEventoCommand("", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true, 0,
            true, "Empresa");
        Inicio(cmd);
        bus.SendCommand(cmd);
        Fim(cmd);

        // Atualizar Evento
        var cmd2 = new AtualizarEventoCommand(Guid.NewGuid(), "DevX", "", "", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), false, 50, 
            true, "Empresa");
        Inicio(cmd);
        bus.SendCommand(cmd);
        Fim(cmd);

        // Excluir Evento
        var cmd3 = new ExcluirEventoCommand(Guid.NewGuid());
        Inicio(cmd);
        bus.SendCommand(cmd);
        Fim(cmd);

        Console.ReadKey();
    }

    private static void Inicio(Message message)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Inicio do Comando" + message.MessageType);
    }

    private static void Fim(Message message)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Fim do comando" + message.MessageType);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("*************");
        Console.WriteLine("");
    }
}

   