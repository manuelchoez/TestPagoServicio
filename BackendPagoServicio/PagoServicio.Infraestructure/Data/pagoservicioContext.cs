using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PagoServicio.Dominio.Entidades;

#nullable disable

namespace PagoServicio.Infraestructure.Data
{
    public partial class pagoservicioContext : DbContext
    {
        public pagoservicioContext()
        {
        }

        public pagoservicioContext(DbContextOptions<pagoservicioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                   .HasName("PK__pago__FC851A3AE8B302EA");

                entity.ToTable("pago");

                entity.Property(e => e.CedulaCliente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPago).HasColumnType("datetime");

                entity.Property(e => e.IdPago).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usuario");

                entity.Property(e => e.Contrasenia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
