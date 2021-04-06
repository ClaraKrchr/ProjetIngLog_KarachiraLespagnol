using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Projet.Data.Models;

namespace Projet.Data.ModelBuilders
{
    public static class ProjectModelBuilder
    {
        public static void CreateModel(ModelBuilder modelBuilder)
        {
            CreateClientModel(modelBuilder);
            CreateFactureModel(modelBuilder);
            CreateProduitModel(modelBuilder);
/*            CreateFactureProduitModel(modelBuilder);
*/        }

        private static void CreateClientModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(c => c.Id);
            modelBuilder.Entity<Client>().Property(c => c.Nom).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(c => c.Prenom).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(c => c.Mail).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(c => c.DateCreation).IsRequired();
        }

        private static void CreateFactureModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facture>().HasKey(f => f.Id);
            modelBuilder.Entity<Facture>().Property(f => f.ClientId).IsRequired();
            modelBuilder.Entity<Facture>().HasOne(f => f.Client).WithMany(x => x.Factures).HasForeignKey(f => f.ClientId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Facture>().Property(f => f.Date).IsRequired();
            modelBuilder.Entity<Facture>().Property(f => f.Paiement).IsRequired();
            modelBuilder.Entity<Facture>().Property(f => f.Prix).IsRequired();
        }

        private static void CreateProduitModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produit>().HasKey(p => p.Id);
            modelBuilder.Entity<Produit>().Property(p => p.Nom).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Produit>().Property(p => p.Prix).IsRequired();
        }

       /* private static void CreateFactureProduitModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProduitFacture>().HasKey(x => new { x.FactureId, x.ProduitId });
            modelBuilder.Entity<ProduitFacture>().HasOne(x => x.Facture).WithMany(y => y.ProduitFactures).HasForeignKey(x => x.FactureId);
            modelBuilder.Entity<ProduitFacture>().HasOne(x => x.Produit).WithMany(y => y.ProduitFactures).HasForeignKey(x => x.ProduitId);
        }*/
    }
}
