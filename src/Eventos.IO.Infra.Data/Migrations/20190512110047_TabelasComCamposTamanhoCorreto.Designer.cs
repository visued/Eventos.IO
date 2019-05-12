﻿// <auto-generated />
using System;
using Eventos.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace Eventos.IO.Infra.Data.Migrations
{
    [DbContext(typeof(EventosContext))]
    [Migration("20190512110047_TabelasComCamposTamanhoCorreto")]
    partial class TabelasComCamposTamanhoCorreto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("Eventos.IO.Domain.Eventos.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Eventos.IO.Domain.Eventos.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("EventoId");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("EventoId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Eventos.IO.Domain.Eventos.Evento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoriaId");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("DescricaoLonga")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<Guid?>("EnderecoId");

                    b.Property<bool>("Excluido");

                    b.Property<bool>("Gratuito");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("Online");

                    b.Property<Guid>("OrganizadorId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("OrganizadorId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Eventos.IO.Domain.Organizadores.Organizador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Organizadores");
                });

            modelBuilder.Entity("Eventos.IO.Domain.Eventos.Endereco", b =>
                {
                    b.HasOne("Eventos.IO.Domain.Eventos.Evento", "Evento")
                        .WithOne("Endereco")
                        .HasForeignKey("Eventos.IO.Domain.Eventos.Endereco", "EventoId");
                });

            modelBuilder.Entity("Eventos.IO.Domain.Eventos.Evento", b =>
                {
                    b.HasOne("Eventos.IO.Domain.Eventos.Categoria", "Categoria")
                        .WithMany("Eventos")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("Eventos.IO.Domain.Organizadores.Organizador", "Organizador")
                        .WithMany("Eventos")
                        .HasForeignKey("OrganizadorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
