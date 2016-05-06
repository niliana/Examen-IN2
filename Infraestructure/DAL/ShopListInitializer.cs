using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Articles;
using Tickets;

namespace Infraestructure.DAL
{
    public class ShopListInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var articles = new List<Article>
            {
            new Article{Name="Pera", Price=0.5m, ArticleId=1},
            new Article{Name="Manzana", Price=0.65m, ArticleId=2},
            new Article{Name="Naranja", Price=0.45m, ArticleId=3},
            };
            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();

            var operation = new List<Operation>
            {
            new Operation{OperationId = 1, Quantity=3, ArticleId=3},
            new Operation{OperationId = 2, Quantity=2, ArticleId=2},
            new Operation{OperationId = 3, Quantity=2, ArticleId=1},
            };
            operation.ForEach(o => context.Operations.Add(o));
            context.SaveChanges();

            var ticket = new List<Ticket>
            {
            new Ticket{TicketId = 1,Date=DateTime.Parse("03-02-2015")},
            new Ticket{TicketId = 2,Date=DateTime.Parse("04-02-2015")},
            new Ticket{TicketId = 3,Date=DateTime.Parse("06-02-2015")},
            };
            ticket.ForEach(t => context.Tikects.Add(t));
            context.SaveChanges();  

        }

    }
}
