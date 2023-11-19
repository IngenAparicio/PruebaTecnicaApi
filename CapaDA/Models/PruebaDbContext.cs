using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CapaDA.Models
{
    public partial class PruebaDbContext : DbContext
    {
        public PruebaDbContext()
        {
        }

        public PruebaDbContext(DbContextOptions<PruebaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<ConsultaPersonas> ConsultaPersonas { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-F5ICL51S; Database=PruebaDb;Trusted_Connection=True;TrustServerCertificate=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.Property(e => e.Apellidos)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.IdCalculada)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NoIdentificacion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.Pass)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioPlat)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsultaPersonas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.IdCalculada)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NoIdentificacion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
