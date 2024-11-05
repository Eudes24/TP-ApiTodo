﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiTodo.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20241105090513_3nd migration")]
    partial class _3ndmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("Todo", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AgendaId")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("TEXT");

                    b.Property<string>("Task")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("Todo", b =>
                {
                    b.HasOne("Agenda", "Agenda")
                        .WithMany("Todos")
                        .HasForeignKey("AgendaId");

                    b.Navigation("Agenda");
                });

            modelBuilder.Entity("Agenda", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
