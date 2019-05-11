using Eventos.IO.Domain.Core.Models;

namespace Eventos.IO.Domain.Eventos
{
    public class Categoria : Entity<Categoria>
    {
        public string Nome { get; private set; }

        // Contrutor para o Ef
        protected Categoria() { }
        public override bool EhValido()
   
        {
            return true;
        }
    }
}