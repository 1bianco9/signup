﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Nuovacartella.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20240203112057_prima versione del db")]
    partial class primaversionedeldb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Prenotazione", b =>
                {
                    b.Property<int>("IdPrenotazione")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DataDiNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Ruolo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sesso")
                        .HasColumnType("TEXT");

                    b.HasKey("IdPrenotazione");

                    b.ToTable("Prenotazioni");
                });

            modelBuilder.Entity("Prodotto", b =>
                {
                    b.Property<int?>("IdProdotto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Articolo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantita")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdProdotto");

                    b.ToTable("Prodotti");
                });
#pragma warning restore 612, 618
        }
    }
}
