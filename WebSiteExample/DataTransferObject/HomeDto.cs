using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteExample.Models;

namespace WebSiteExample.DataTransferObject
{
    public class HomeDto
    {
        public List<Products> ProductsTable { get; set; }
        public List<ShoppingCard> ProductsCard { get; set; }
    }
}
