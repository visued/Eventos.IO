﻿using System;
using System.Collections.Generic;
using System.Text;
using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Interfaces;
using Eventos.IO.Infra.Data.Context;

namespace Eventos.IO.Infra.Data.UoW
{
    public class UnityOfwork : IUnitOfWork
    {
        private readonly EventosContext _context;

        public UnityOfwork(EventosContext context)
        {
            _context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
