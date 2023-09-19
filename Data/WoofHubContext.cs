using Microsoft.EntityFrameworkCore;
using WoofHub_App.Models;

namespace WoofHub_App.Data
{
    public class WoofHubContext : DbContext
    {
        public WoofHubContext(DbContextOptions<WoofHubContext> options)
            : base(options)
        {
            
        }

        public DbSet<AnimalModel> Animals { get; set; }
    }
}