using Demo.Micro.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Micro.Data
{
    public class CertificationDbContext : DbContext
    {
        public CertificationDbContext(DbContextOptions<CertificationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Certification> Certifications { get; set; }
    }
}
