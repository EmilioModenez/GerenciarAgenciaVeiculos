﻿// <auto-generated />
using System;
using GerenciarAgenciaVeiculos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciarAgenciaVeiculos.Models.Migrations
{
    [DbContext(typeof(GerenciarVeiculosContext))]
    [Migration("20210123163315_TabelasCliente_Endereco_Telefone")]
    partial class TabelasCliente_Endereco_Telefone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GerenciarAgenciaVeiculos.Models.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<string>("Chassi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CilindradaMotor")
                        .HasColumnType("int");

                    b.Property<string>("Combustivel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantidadePortas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("GerenciarAgenciaVeiculos.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("GerenciarAgenciaVeiculos.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("GerenciarAgenciaVeiculos.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("DDD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("GerenciarAgenciaVeiculos.Models.Endereco", b =>
                {
                    b.HasOne("GerenciarAgenciaVeiculos.Models.Cliente", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("GerenciarAgenciaVeiculos.Models.Telefone", b =>
                {
                    b.HasOne("GerenciarAgenciaVeiculos.Models.Cliente", null)
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("GerenciarAgenciaVeiculos.Models.Cliente", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
