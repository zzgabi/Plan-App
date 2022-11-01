using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PlanApp.Models.DBObjects
{
    public partial class planAppContext : DbContext
    {
        public planAppContext()
        {
        }

        public planAppContext(DbContextOptions<planAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminManagement> AdminManagements { get; set; } = null!;
        public virtual DbSet<Administratori> Administratoris { get; set; } = null!;
        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        //public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        //public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<Camere> Cameres { get; set; } = null!;
        public virtual DbSet<Camine> Camines { get; set; } = null!;
        public virtual DbSet<Plati> Platis { get; set; } = null!;
        public virtual DbSet<Studenti> Studentis { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {     
                optionsBuilder.UseSqlServer("Name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminManagement>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.ToTable("admin_management");

                entity.Property(e => e.IdStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_status");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Mesaj)
                    .HasMaxLength(50)
                    .HasColumnName("mesaj");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Administratori>(entity =>
            {
                entity.HasKey(e => e.IdAdministrator)
                    .HasName("PK_administratori_1");

                entity.ToTable("administratori");

                entity.Property(e => e.IdAdministrator)
                    .ValueGeneratedNever()
                    .HasColumnName("id_administrator");

                entity.Property(e => e.IdCamin).HasColumnName("id_camin");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdCaminNavigation)
                    .WithMany(p => p.Administratoris)
                    .HasForeignKey(d => d.IdCamin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_administratori_camine");
            });

            //modelBuilder.Entity<AspNetRole>(entity =>
            //{
            //    entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
            //        .IsUnique()
            //        .HasFilter("([NormalizedName] IS NOT NULL)");

            //    entity.Property(e => e.Name).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedName).HasMaxLength(256);
            //});

            //modelBuilder.Entity<AspNetRoleClaim>(entity =>
            //{
            //    entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.AspNetRoleClaims)
            //        .HasForeignKey(d => d.RoleId);
            //});

            //modelBuilder.Entity<AspNetUser>(entity =>
            //{
            //    entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            //    entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
            //        .IsUnique()
            //        .HasFilter("([NormalizedUserName] IS NOT NULL)");

            //    entity.Property(e => e.Email).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

            //    entity.Property(e => e.UserName).HasMaxLength(256);

            //    entity.HasMany(d => d.Roles)
            //        .WithMany(p => p.Users)
            //        .UsingEntity<Dictionary<string, object>>(
            //            "AspNetUserRole",
            //            l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
            //            r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
            //            j =>
            //            {
            //                j.HasKey("UserId", "RoleId");

            //                j.ToTable("AspNetUserRoles");

            //                j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
            //            });
            //});

            //modelBuilder.Entity<AspNetUserClaim>(entity =>
            //{
            //    entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserClaims)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUserLogin>(entity =>
            //{
            //    entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            //    entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            //    entity.Property(e => e.LoginProvider).HasMaxLength(128);

            //    entity.Property(e => e.ProviderKey).HasMaxLength(128);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserLogins)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUserToken>(entity =>
            //{
            //    entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            //    entity.Property(e => e.LoginProvider).HasMaxLength(128);

            //    entity.Property(e => e.Name).HasMaxLength(128);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserTokens)
            //        .HasForeignKey(d => d.UserId);
            //});

            modelBuilder.Entity<Camere>(entity =>
            {
                entity.HasKey(e => e.IdCamera)
                    .HasName("PK_camere_1");

                entity.ToTable("camere");

                entity.Property(e => e.IdCamera)
                    .ValueGeneratedNever()
                    .HasColumnName("id_camera");

                entity.Property(e => e.IdCamin).HasColumnName("id_camin");

                entity.Property(e => e.LocuriLibere).HasColumnName("locuri_libere");

                entity.Property(e => e.LocuriOcupate).HasColumnName("locuri_ocupate");

                entity.Property(e => e.NumeCam)
                    .HasMaxLength(50)
                    .HasColumnName("numeCam");

                entity.Property(e => e.Poza)
                    .HasMaxLength(500)
                    .HasColumnName("poza");

                entity.Property(e => e.PretCamera)
                    .HasColumnType("money")
                    .HasColumnName("pret_camera");

                entity.Property(e => e.StatusCamera)
                    .HasMaxLength(50)
                    .HasColumnName("status_camera");

                entity.Property(e => e.TotalLocuri).HasColumnName("total_locuri");

                entity.HasOne(d => d.IdCaminNavigation)
                    .WithMany(p => p.Cameres)
                    .HasForeignKey(d => d.IdCamin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_camere_camine");
            });

            modelBuilder.Entity<Camine>(entity =>
            {
                entity.HasKey(e => e.IdCamin)
                    .HasName("PK_camine_1");

                entity.ToTable("camine");

                entity.Property(e => e.IdCamin)
                    .ValueGeneratedNever()
                    .HasColumnName("id_camin");

                entity.Property(e => e.AdresaCamin)
                    .HasMaxLength(200)
                    .HasColumnName("adresa_camin");

                entity.Property(e => e.Foto)
                    .HasMaxLength(500)
                    .HasColumnName("foto");

                entity.Property(e => e.NrCamere).HasColumnName("nr_camere");

                entity.Property(e => e.NumeCamin)
                    .HasMaxLength(50)
                    .HasColumnName("nume_camin");

                entity.Property(e => e.Oras)
                    .HasMaxLength(50)
                    .HasColumnName("oras");
            });

            modelBuilder.Entity<Plati>(entity =>
            {
                entity.HasKey(e => e.IdPlata)
                    .HasName("PK_plati_1");

                entity.ToTable("plati");

                entity.Property(e => e.IdPlata)
                    .ValueGeneratedNever()
                    .HasColumnName("id_plata");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("data");

                entity.Property(e => e.IdCamera).HasColumnName("id_camera");

                entity.Property(e => e.IdCamin).HasColumnName("id_camin");

                entity.Property(e => e.IdStudent).HasColumnName("id_student");

                entity.HasOne(d => d.IdCameraNavigation)
                    .WithMany(p => p.Platis)
                    .HasForeignKey(d => d.IdCamera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_plati_camere");

                entity.HasOne(d => d.IdCaminNavigation)
                    .WithMany(p => p.Platis)
                    .HasForeignKey(d => d.IdCamin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_plati_camine");

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.Platis)
                    .HasForeignKey(d => d.IdStudent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_plati_studenti");
            });

            modelBuilder.Entity<Studenti>(entity =>
            {
                entity.HasKey(e => e.IdStudent)
                    .HasName("PK_studenti_1");

                entity.ToTable("studenti");

                entity.Property(e => e.IdStudent)
                    .ValueGeneratedNever()
                    .HasColumnName("id_student");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.IdCamera).HasColumnName("id_camera");

                entity.Property(e => e.Mobil)
                    .HasMaxLength(50)
                    .HasColumnName("mobil");

                entity.Property(e => e.NumeStudent)
                    .HasMaxLength(100)
                    .HasColumnName("nume_student");

                entity.Property(e => e.RestPlata)
                    .HasColumnType("money")
                    .HasColumnName("rest_plata");

                entity.Property(e => e.StatusPlata)
                    .HasMaxLength(100)
                    .HasColumnName("status_plata");

                entity.HasOne(d => d.IdCameraNavigation)
                    .WithMany(p => p.Studentis)
                    .HasForeignKey(d => d.IdCamera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_studenti_camere");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("users");

                entity.Property(e => e.IdUser)
                    .ValueGeneratedNever()
                    .HasColumnName("id_user");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
