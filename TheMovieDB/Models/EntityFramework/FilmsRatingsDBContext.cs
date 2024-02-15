using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace TheMovieDB.Models.EntityFramework
{
    public partial class FilmsRatingsDBContext : DbContext
    {

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        
        public FilmsRatingsDBContext()
        {
        }

        public FilmsRatingsDBContext(DbContextOptions<FilmsRatingsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<t_e_film_flm> Films { get; set; } = null!;
        public virtual DbSet<t_e_utilisateur_utl> Utilisateurs { get; set; } = null!;
        public virtual DbSet<t_j_notation_not> Notes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseLoggerFactory(MyLoggerFactory)
                              .EnableSensitiveDataLogging()
                              .UseNpgsql("Server=localhost;port=5432;Database=FilmsDB;uid = postgres; password = postgres; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_e_film_flm>(entity =>
            {
                entity.HasKey(e => new { e.FilmId })
                    .HasName("pk_films");
            });

            modelBuilder.Entity<t_e_utilisateur_utl>(entity =>
            {
                entity.HasKey(e => new { e.UtilisateurId })
                    .HasName("pk_utilisateurs");
            });

            modelBuilder.Entity<t_j_notation_not>(entity =>
            {
                entity.HasKey(e => new { e.UtilisateurId, e.FilmId })
                    .HasName("pk_notes");

                entity.HasOne(d => d.FilmNote)
                    .WithMany(p => p.NotesFilm)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_note_film");

                entity.HasOne(d => d.UtilisateurNotant)
                    .WithMany(p => p.NotesUtilisateur)
                    .HasForeignKey(d => d.UtilisateurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_avis_utilisateur");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
