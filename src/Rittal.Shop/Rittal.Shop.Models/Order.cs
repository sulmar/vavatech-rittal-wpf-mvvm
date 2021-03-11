using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rittal.Shop.Models
{
    public class Order : BaseEntity
    {
        public string Number { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }
        public decimal TotalAmount => Details.Sum(d => d.TotalAmount);
    }

    public class OrderDetail : BaseEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal TotalAmount => Quantity * UnitPrice;

    }

    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
