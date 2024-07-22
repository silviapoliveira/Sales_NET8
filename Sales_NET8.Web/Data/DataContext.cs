using Sales_NET8.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Sales_NET8.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}
