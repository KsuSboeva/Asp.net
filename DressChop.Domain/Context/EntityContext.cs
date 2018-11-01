using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DressChop.Domain.Entities;

namespace DressChop.Domain.Context
{
    public class EntityContext : DbContext
    {
        //EntityContext(): base("Connect")
        //{

        //}
        
        public DbSet<Product> Products { get; set; }
    }
}
