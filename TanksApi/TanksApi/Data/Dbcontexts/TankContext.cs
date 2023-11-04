using Microsoft.EntityFrameworkCore;
using TanksApi.Models;

namespace TanksApi.Data.Dbcontexts
{
    public class TankContext : DbContext
    {
        public TankContext()
        {
        }

        public TankContext(DbContextOptions<TankContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TanksDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public virtual DbSet<Tank> Tanks { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<Level> Levels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var tankBuilder = modelBuilder.Entity<Tank>();
            var levelBuilder = modelBuilder.Entity<Level>();
            var nationBuilder = modelBuilder.Entity<Nation>();

            // Tanks
            {
                tankBuilder
                    .HasKey(x => x.Id);
                tankBuilder
                    .Property(x => x.Id)
                    .ValueGeneratedOnAdd();
                tankBuilder
                    .Property(x => x.Name)
                    .IsRequired();
                tankBuilder
                    .Property(x => x.Price)
                    .IsRequired();
                tankBuilder
                    .HasOne(t => t.Nation)
                    .WithMany(n => n.Tanks)
                    .HasForeignKey(t => t.NationId);
                tankBuilder
                    .HasOne(t => t.Level)
                    .WithMany(l => l.Tanks)
                    .HasForeignKey(t => t.LevelId);
            }

            // Nations
            {
                nationBuilder
                    .HasKey(x => x.Id);
                nationBuilder
                    .Property(x => x.Id)
                    .ValueGeneratedOnAdd();
                nationBuilder
                    .Property(x => x.Name)
                    .IsRequired();
                nationBuilder
                    .HasMany(n => n.Tanks)
                    .WithOne(t => t.Nation)
                    .HasForeignKey(t => t.NationId);
            }

            // Levels
            {
                levelBuilder
                    .HasKey(x => x.Id);
                levelBuilder
                    .Property(x => x.Id)
                    .ValueGeneratedOnAdd();
                levelBuilder
                    .Property(l => l.TankLevel)
                    .IsRequired();
                levelBuilder
                    .HasMany(l => l.Tanks)
                    .WithOne(t => t.Level)
                    .HasForeignKey(t => t.LevelId);
            }

        }

    }
}
