using System;
using System.Collections.Generic;
using System.Text;
using Eventos.IO.Domain.Eventos;
using Eventos.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventos.IO.Infra.Data.Mappings
{
    public class CategoriaMapping : EntityTypeConfiguration<Categoria>
    {
        public override void Map(EntityTypeBuilder<Categoria> builder)
        {
            builder.Ignore(e => e.ValidationResult);

            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Categorias");
        }
    }
}
