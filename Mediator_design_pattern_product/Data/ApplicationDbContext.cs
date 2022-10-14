using Mediator_design_pattern_product.Model;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }


        public DbSet<Product> Product { get; set; }
    }
}
