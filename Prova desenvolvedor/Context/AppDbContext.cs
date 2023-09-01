using Microsoft.EntityFrameworkCore;
using Prova_desenvolvedor.Models;

namespace Prova_desenvolvedor.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ativo>()
                .Property(c => c.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Order>()
                .Property(c => c.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.Type)
                .IsRequired()
                .HasMaxLength(1);


            modelBuilder.HasAnnotation("SqlServer:CheckConstraint:CK_Order_Type", "Type IN (1, 2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
