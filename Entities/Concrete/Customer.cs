using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
