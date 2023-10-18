using Microsoft.EntityFrameworkCore;

namespace entityFramework.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conectionString = "Server=HAMACHORROM-L14; Database=CodeFirstDB; Integrated Security=true; TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(conectionString);
        }
    }
}
