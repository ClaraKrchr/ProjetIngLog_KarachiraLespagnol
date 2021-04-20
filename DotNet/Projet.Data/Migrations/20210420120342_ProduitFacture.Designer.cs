﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projet.Data;

namespace Projet.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210420120342_ProduitFacture")]
    partial class ProduitFacture
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Projet.Data.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Projet.Data.Models.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DatePaiement")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Paiement")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Prix")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("Projet.Data.Models.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Facture")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Prix")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Produits");
                });

            modelBuilder.Entity("Projet.Data.Models.Facture", b =>
                {
                    b.HasOne("Projet.Data.Models.Client", "Client")
                        .WithMany("Factures")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Projet.Data.Models.Client", b =>
                {
                    b.Navigation("Factures");
                });
#pragma warning restore 612, 618
        }
    }
}
