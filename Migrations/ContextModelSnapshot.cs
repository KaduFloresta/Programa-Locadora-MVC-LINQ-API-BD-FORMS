﻿// <auto-generated />
using System;
using DbRespositorie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocadoraMVC.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Models.ClienteModels", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CpfCliente")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("DiasDevolucao")
                        .HasColumnType("int");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Models.FilmeModels", b =>
                {
                    b.Property<int>("IdFilme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DataLancamento")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("EstoqueFilme")
                        .HasColumnType("int");

                    b.Property<int>("FilmeLocado")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("ValorLocacaoFilme")
                        .HasColumnType("double");

                    b.HasKey("IdFilme");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("Models.LocacaoFilmeModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FilmeIdFilme")
                        .HasColumnType("int");

                    b.Property<int>("IdFilme")
                        .HasColumnType("int");

                    b.Property<int>("IdLocacao")
                        .HasColumnType("int");

                    b.Property<int?>("LocacaoIdLocacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmeIdFilme");

                    b.HasIndex("LocacaoIdLocacao");

                    b.ToTable("LocacaoFilme");
                });

            modelBuilder.Entity("Models.LocacaoModels", b =>
                {
                    b.Property<int>("IdLocacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.HasKey("IdLocacao");

                    b.HasIndex("ClienteIdCliente");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Models.LocacaoFilmeModels", b =>
                {
                    b.HasOne("Models.FilmeModels", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeIdFilme");

                    b.HasOne("Models.LocacaoModels", "Locacao")
                        .WithMany()
                        .HasForeignKey("LocacaoIdLocacao");
                });

            modelBuilder.Entity("Models.LocacaoModels", b =>
                {
                    b.HasOne("Models.ClienteModels", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteIdCliente");
                });
#pragma warning restore 612, 618
        }
    }
}