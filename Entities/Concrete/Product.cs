using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product :BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public bool IsDiscount { get; set; }
        public int DiscountRate { get; set; }
    }
}
