using JWT_Auth.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace JWT_Auth.Data.Dbcontexts
{
    public class UserContext : DbContext
    {
        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var userBuilder = modelBuilder.Entity<User>();

            userBuilder
                .HasKey(x => x.Id);
            userBuilder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
            userBuilder
                .Property(x => x.Name)
                .IsRequired();
            userBuilder
                .Property(x => x.Email)
                .IsRequired();
            userBuilder
                .Property(x => x.Password)
                .IsRequired();
        }



    }
}
