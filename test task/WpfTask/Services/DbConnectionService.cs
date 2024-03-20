using Microsoft.EntityFrameworkCore;

namespace WpfTask.Services
{
    internal class DbConnectionService : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=task1.sql;User Id=postgres;Password=admin");
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
