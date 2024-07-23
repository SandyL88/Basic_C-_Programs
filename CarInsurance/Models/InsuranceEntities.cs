using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;  // Ensure this using directive is present

namespace CarInsurance.Models
{
    public class InsuranceEntities : DbContext
    {
        public InsuranceEntities(DbContextOptions<InsuranceEntities> options)
            : base(options)
        {
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
