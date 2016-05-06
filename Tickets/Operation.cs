using Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Operation
    {
        public int OperationId { get; set; }
        public int Quantity { get; set; }
        public int ArticleId { get; set; }
        public int Price { get; set; }
        public virtual Article Articles { get; set; }



    }
}
