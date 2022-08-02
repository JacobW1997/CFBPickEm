using System;
using System.Collections.Generic;
using CFBPickEm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CFBPickEm.DAL
{
    public partial class CFBPickEmDbContext : DbContext
    {
        public CFBPickEmDbContext()
        {
        }

        public CFBPickEmDbContext(DbContextOptions<CFBPickEmDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MatchSelection> MatchSelections { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=CFBServerConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MatchSelection>(entity =>
            {
                entity.Property(e => e.LosingTeamName).IsFixedLength();

                entity.Property(e => e.WinningTeamName).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
