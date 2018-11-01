using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AbstractRepository
{
    interface ProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
