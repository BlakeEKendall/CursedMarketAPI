using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Products
{
    public class ProductListItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        //public int NumberOrdered { get; set; }
        //extra work - create order service that can tell you how many times the product has been ordered?
    }
}
