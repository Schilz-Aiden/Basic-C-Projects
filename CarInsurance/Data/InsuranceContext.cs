using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Data
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Insuree> Insuree { get; set; }
    }
}
