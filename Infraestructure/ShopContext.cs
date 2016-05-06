using Articles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets;

namespace Infraestructure
{
    public class ShopContext : DbContext, IDbContext, IUnitOfWork
    {
        public ShopContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Ticket> Tikects { get; set; }
        public DbSet<Operation> Operations { get; set; }

        public IDbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

    }
}
