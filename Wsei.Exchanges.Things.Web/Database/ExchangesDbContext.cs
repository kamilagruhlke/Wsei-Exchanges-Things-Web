using Microsoft.EntityFrameworkCore;
using Wsei.Exchanges.Things.Web.Entities;

namespace Wsei.Exchanges.Things.Web.Database
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ItemEntity> Items { get; set; }
    }
}
