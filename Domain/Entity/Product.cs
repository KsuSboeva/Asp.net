using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
