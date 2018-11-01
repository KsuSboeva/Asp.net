using DressChop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressChop.Domain.Abstract
{
   public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
