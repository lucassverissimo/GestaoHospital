﻿// <auto-generated />
using System;
using GestaoHospital.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaoHospital.WebAPI.Migrations
{
    [DbContext(typeof(GHContext))]
    [Migration("20231123154236_remover_observacaooutro")]
    partial class remover_observacaooutro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GestaoHospital.WebAPI.Models.Anotacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Prescricao")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Anotacao");
                });

            modelBuilder.Entity("GestaoHospital.WebAPI.Models.CaracteristicaDieta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dieta")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Evoluido")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Sistema")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("CaracteristicaDieta");
                });

            modelBuilder.Entity("GestaoHospital.WebAPI.Models.Mapa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnotacaoId")
                        .HasColumnType("int");

                    b.Property<int>("CaracteristicaDietaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPrescricao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Dieta")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Leito")
                        .HasColumnType("int");

                    b.Property<string>("ObservacaoDieta")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ObservacaoId")
                        .HasColumnType("int");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnotacaoId");

                    b.HasIndex("CaracteristicaDietaId");

                    b.HasIndex("ObservacaoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Mapas");
                });

            modelBuilder.Entity("GestaoHospital.WebAPI.Models.Observacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dialise")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Outros")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Observacao");
                });

            modelBuilder.Entity("GestaoHospital.WebAPI.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("GestaoHospital.WebAPI.Models.Mapa", b =>
                {
                    b.HasOne("GestaoHospital.WebAPI.Models.Anotacao", "Anotacao")
                        .WithMany()
                        .HasForeignKey("AnotacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoHospital.WebAPI.Models.CaracteristicaDieta", "CaracteristicaDieta")
                        .WithMany()
                        .HasForeignKey("CaracteristicaDietaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoHospital.WebAPI.Models.Observacao", "Observacao")
                        .WithMany()
                        .HasForeignKey("ObservacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoHospital.WebAPI.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
