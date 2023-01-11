﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prova_liveshare;

#nullable disable

namespace Provaliveshare.Migrations
{
    [DbContext(typeof(TodoListDbContext))]
    partial class TodoListDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prova_liveshare.Attivita", b =>
                {
                    b.Property<int>("IdAttivita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAttivita"));

                    b.Property<string>("Creatore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAttivita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ListaAttivitaIdLista")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAttivita");

                    b.HasIndex("ListaAttivitaIdLista");

                    b.ToTable("Attivita");
                });

            modelBuilder.Entity("Prova_liveshare.ListaAttivita", b =>
                {
                    b.Property<int>("IdLista")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLista"));

                    b.Property<int>("AttivitaIdAttivita")
                        .HasColumnType("int");

                    b.Property<int>("IdAttivita")
                        .HasColumnType("int");

                    b.Property<string>("NomeLista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLista");

                    b.HasIndex("AttivitaIdAttivita");

                    b.ToTable("ListaAttivita");
                });

            modelBuilder.Entity("Prova_liveshare.Attivita", b =>
                {
                    b.HasOne("Prova_liveshare.ListaAttivita", null)
                        .WithMany("Task")
                        .HasForeignKey("ListaAttivitaIdLista");
                });

            modelBuilder.Entity("Prova_liveshare.ListaAttivita", b =>
                {
                    b.HasOne("Prova_liveshare.Attivita", "Attivita")
                        .WithMany()
                        .HasForeignKey("AttivitaIdAttivita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attivita");
                });

            modelBuilder.Entity("Prova_liveshare.ListaAttivita", b =>
                {
                    b.Navigation("Task");
                });
#pragma warning restore 612, 618
        }
    }
}
