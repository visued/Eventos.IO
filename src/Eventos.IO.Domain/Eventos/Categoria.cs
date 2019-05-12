using System;
using System.Collections;
using System.Collections.Generic;
using Eventos.IO.Domain.Core.Models;

namespace Eventos.IO.Domain.Eventos
{
    public class Categoria : Entity<Categoria>
    {
        public Categoria(Guid id)
        {
            Id = id;
        }

        public string Nome { get; private set; }

        // Ef Propriedade de Navegação
        public virtual ICollection<Evento> Eventos { get; set; }

        // Contrutor para o Ef
        protected Categoria() { }
        public override bool EhValido()
   
        {
            return true;
        }
    }
}