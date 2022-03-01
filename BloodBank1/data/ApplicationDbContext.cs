using BloodBank1.model;
using bloodbank23.model;
using BlooodBank.model;
using Microsoft.EntityFrameworkCore;

namespace bloodbank23.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<BloodDetails> BloodDetails { get; set; }
        public DbSet<KindOfOrg> Kindoforgi { get; set; }
        public DbSet<BloodName> BloodNames { get; set; }
        public DbSet<Hemoglobin> Hemoglobins { get; set; }
    }
}
