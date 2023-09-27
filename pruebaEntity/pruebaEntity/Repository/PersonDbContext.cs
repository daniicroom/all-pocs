using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using pruebaEntity.Repository.Models;

#nullable disable

namespace pruebaEntity.Repository
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

        public virtual DbSet<Aspnetrole> Aspnetroles { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Encuesta> Encuestas { get; set; }
        public virtual DbSet<Input> Inputs { get; set; }
        public virtual DbSet<Inssuingquotation> Inssuingquotations { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Modeloutput> Modeloutputs { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pregunta> Preguntas { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Respuesta> Respuestas { get; set; }
        public virtual DbSet<RoleApp> RoleApps { get; set; }
        public virtual DbSet<Sheet> Sheets { get; set; }
        public virtual DbSet<SubtiposCultivo> SubtiposCultivos { get; set; }
        public virtual DbSet<TipoRespuesta> TipoRespuestas { get; set; }
        public virtual DbSet<TiposCultivo> TiposCultivos { get; set; }
        public virtual DbSet<Userapp> Userapps { get; set; }
        public virtual DbSet<Userappbook> Userappbooks { get; set; }
        public virtual DbSet<Vereda> Veredas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-4RO6MM9\\SQLEXPRESS;Initial Catalog=localDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Aspnetrole>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Encuesta>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.Encuesta)
                    .HasForeignKey(d => d.IdPregunta)
                    .HasConstraintName("FK__encuestas__id_pr__6754599E");

                entity.HasOne(d => d.IdTipoRespuestaNavigation)
                    .WithMany(p => p.Encuesta)
                    .HasForeignKey(d => d.IdTipoRespuesta)
                    .HasConstraintName("FK__encuestas__id_ti__68487DD7");
            });

            modelBuilder.Entity<Input>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Inssuingquotation>(entity =>
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

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Modeloutput>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pregunta>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Input)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.InputId)
                    .HasConstraintName("FK__quote__InputId__5DCAEF64");
            });

            modelBuilder.Entity<Respuesta>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.TipoRespuesta)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.TipoRespuestaId)
                    .HasConstraintName("FK__respuesta__tipo___5EBF139D");
            });

            modelBuilder.Entity<RoleApp>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__roleApp__AF2760AD7FAE5194");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RoleApps)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__roleApp__UserId__5FB337D6");
            });

            modelBuilder.Entity<Sheet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Sheets)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__sheets__BookId__619B8048");
            });

            modelBuilder.Entity<SubtiposCultivo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdTipoCultivoNavigation)
                    .WithMany(p => p.SubtiposCultivos)
                    .HasForeignKey(d => d.IdTipoCultivo)
                    .HasConstraintName("FK__subtipos___id_ti__628FA481");
            });

            modelBuilder.Entity<TipoRespuesta>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TiposCultivo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Userapp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Userappbook>(entity =>
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

            modelBuilder.Entity<Vereda>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
