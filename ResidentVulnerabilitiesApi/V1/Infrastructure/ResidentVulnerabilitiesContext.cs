using Microsoft.EntityFrameworkCore;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.V1.Infrastructure
{

    public class ResidentVulnerabilitiesContext : DbContext
    {
        public ResidentVulnerabilitiesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Resident> ResidentInformation { get; set; }
    }
}
