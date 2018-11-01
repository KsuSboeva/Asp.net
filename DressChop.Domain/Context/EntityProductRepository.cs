using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DressChop.Domain.Entities;
using DressChop.Domain.Abstract;


namespace DressChop.Domain.Context
{
    public class EntityProductRepository :IProductsRepository 
    {
        EntityContext context = new EntityContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
