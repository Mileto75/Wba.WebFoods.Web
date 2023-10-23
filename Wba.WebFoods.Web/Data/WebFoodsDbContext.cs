using Microsoft.EntityFrameworkCore;
using Wba.WebFoods.Core.Entities;

namespace Wba.WebFoods.Web.Data
{
    public class WebFoodsDbContext : DbContext
    {
        //define DbSets that represent tables
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Property> Properties { get; set; }
        public WebFoodsDbContext(DbContextOptions<WebFoodsDbContext> 
            options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
