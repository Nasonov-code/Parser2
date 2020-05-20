using Microsoft.EntityFrameworkCore;


namespace Parser2.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<CargoInvite> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}