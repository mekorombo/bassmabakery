using Bassma.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bassma.Data
{
    public class BakeryDbContext : IdentityDbContext<IdentityUser>
    {
        public BakeryDbContext(DbContextOptions<BakeryDbContext> options)
            : base(options)
        { }
        public DbSet<Produit> Produits { get; set; }
        //public DbSet<Commande> Commandes { get; set; }
        //public DbSet<Livraison> Livraisons { get; set; }
        //public DbSet<Paiement> Paiements { get; set; }
        //public DbSet<Promotion> Promotions { get; set; }
        //public DbSet<ProduitCommande> ProduitCommandes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(p => p.Id); // Spécification explicite de la clé primaire
                entity.Property(p => p.Nom).IsRequired().HasMaxLength(100); // Nom obligatoire avec une limite de 100 caractères
                entity.Property(p => p.Quantite).HasMaxLength(50); // Quantité avec max 50 caractères
                entity.Property(p => p.Prix).HasPrecision(18, 2); // Précision pour le prix
            });

        }
}
}
