using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using prueba.Repository.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prueba.Repository
{
    public partial class PersonDbContext : DbContext
    {
        public PersonDbContext()
        {
        }

        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Encuestas> Encuestas { get; set; }
        public virtual DbSet<Input> Input { get; set; }
        public virtual DbSet<Inssuingquotations> Inssuingquotations { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Modeloutputs> Modeloutputs { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Preguntas> Preguntas { get; set; }
        public virtual DbSet<Quote> Quote { get; set; }
        public virtual DbSet<Respuestas> Respuestas { get; set; }
        public virtual DbSet<RoleApp> RoleApp { get; set; }
        public virtual DbSet<Sheets> Sheets { get; set; }
        public virtual DbSet<SubtiposCultivos> SubtiposCultivos { get; set; }
        public virtual DbSet<TipoRespuestas> TipoRespuestas { get; set; }
        public virtual DbSet<TiposCultivos> TiposCultivos { get; set; }
        public virtual DbSet<Userapp> Userapp { get; set; }
        public virtual DbSet<Userappbooks> Userappbooks { get; set; }
        public virtual DbSet<Veredas> Veredas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-4RO6MM9\\SQLEXPRESS;Initial Catalog=localDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aspnetroles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Encuestas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.Encuestas)
                    .HasForeignKey(d => d.IdPregunta)
                    .HasConstraintName("FK__encuestas__id_pr__6754599E");

                entity.HasOne(d => d.IdTipoRespuestaNavigation)
                    .WithMany(p => p.Encuestas)
                    .HasForeignKey(d => d.IdTipoRespuesta)
                    .HasConstraintName("FK__encuestas__id_ti__68487DD7");
            });

            modelBuilder.Entity<Input>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Inssuingquotations>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Inssuingquotations)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__inssuingq__BookI__5AEE82B9");

                entity.HasOne(d => d.Input)
                    .WithMany(p => p.Inssuingquotations)
                    .HasForeignKey(d => d.InputId)
                    .HasConstraintName("FK__inssuingq__Input__59FA5E80");

                entity.HasOne(d => d.UserApp)
                    .WithMany(p => p.Inssuingquotations)
                    .HasForeignKey(d => d.UserAppId)
                    .HasConstraintName("FK__inssuingq__UserA__5812160E");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Modeloutputs>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Preguntas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Input)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.InputId)
                    .HasConstraintName("FK__quote__InputId__5DCAEF64");
            });

            modelBuilder.Entity<Respuestas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.TipoRespuesta)
                    .WithMany(p => p.Respuestas)
                    .HasForeignKey(d => d.TipoRespuestaId)
                    .HasConstraintName("FK__respuesta__tipo___5EBF139D");
            });

            modelBuilder.Entity<RoleApp>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__roleApp__AF2760AD7FAE5194");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RoleApp)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__roleApp__UserId__5FB337D6");
            });

            modelBuilder.Entity<Sheets>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Sheets)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__sheets__BookId__619B8048");
            });

            modelBuilder.Entity<SubtiposCultivos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdTipoCultivoNavigation)
                    .WithMany(p => p.SubtiposCultivos)
                    .HasForeignKey(d => d.IdTipoCultivo)
                    .HasConstraintName("FK__subtipos___id_ti__628FA481");
            });

            modelBuilder.Entity<TipoRespuestas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TiposCultivos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Userapp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Userappbooks>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.UserAppId })
                    .HasName("PK__userappb__298AF2937FD84470");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Userappbooks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__userappbo__BookI__66603565");

                entity.HasOne(d => d.UserApp)
                    .WithMany(p => p.Userappbooks)
                    .HasForeignKey(d => d.UserAppId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__userappbo__UserA__656C112C");
            });

            modelBuilder.Entity<Veredas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
