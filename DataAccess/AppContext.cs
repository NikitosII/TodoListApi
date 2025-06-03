
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

// Контекст базы данных
namespace DataAccess
{
    public class AppContext(DbContextOptions<AppContext> options) : DbContext(options)
    {
        public DbSet<Node> Nodes { get; set; } // Таблица заметок
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка модели данных
            modelBuilder.Entity<Node>().HasKey(x => x.Id);
            modelBuilder.Entity<Node>().Property(x => x.Title).HasMaxLength(50);
            base.OnModelCreating(modelBuilder);
        }
    }
}
