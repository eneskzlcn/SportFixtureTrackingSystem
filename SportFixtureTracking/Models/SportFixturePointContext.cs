using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SportFixtureTracking.Models
{
    public partial class SportFixturePointContext : DbContext
    {
        public SportFixturePointContext()
        {
        }

        public SportFixturePointContext(DbContextOptions<SportFixturePointContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Fixture> Fixtures { get; set; }
        public virtual DbSet<FixtureResult> FixtureResults { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SportFixturePoint;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Club>(entity =>
            {
                entity.ToTable("Club");

                entity.Property(e => e.ClubId).ValueGeneratedNever();

                entity.Property(e => e.ClubDescription).HasMaxLength(50);

                entity.Property(e => e.ClubName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Fixture>(entity =>
            {
                entity.ToTable("Fixture");

                entity.Property(e => e.FixtureId).ValueGeneratedNever();

                entity.Property(e => e.FixtureDate).HasColumnType("date");

                entity.Property(e => e.FixtureHome).HasMaxLength(50);

                entity.Property(e => e.IsFinished)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.AwayTeam)
                    .WithMany(p => p.FixtureAwayTeams)
                    .HasForeignKey(d => d.AwayTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fixture_ToTeam2");

                entity.HasOne(d => d.HomeTeam)
                    .WithMany(p => p.FixtureHomeTeams)
                    .HasForeignKey(d => d.HomeTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fixture_ToTeam");
            });

            modelBuilder.Entity<FixtureResult>(entity =>
            {
                entity.HasKey(e => e.ResultId)
                    .HasName("PK__FixtureR__976902087EF3B71B");

                entity.ToTable("FixtureResult");

                entity.Property(e => e.ResultId).ValueGeneratedNever();

                entity.HasOne(d => d.Fixture)
                    .WithMany(p => p.FixtureResults)
                    .HasForeignKey(d => d.FixtureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FixtureResult_ToFixture");

                entity.HasOne(d => d.WinnerTeam)
                    .WithMany(p => p.FixtureResults)
                    .HasForeignKey(d => d.WinnerTeamId)
                    .HasConstraintName("FK_FixtureResult_ToTeam");
            });

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.ToTable("Sport");

                entity.Property(e => e.SportId).ValueGeneratedNever();

                entity.Property(e => e.SportDescription).HasMaxLength(50);

                entity.Property(e => e.SportName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.Property(e => e.TeamId).ValueGeneratedNever();

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.ClubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_ToClub");

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.SportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_ToSport");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
