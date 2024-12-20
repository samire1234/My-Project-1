using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager(ICustomerDal customerDal) : ICustomerService
    {
        private readonly ICustomerDal _customerDal=customerDal;
        public void Add(Customer customer)
        {
            if (customer.CustomerName.Length>6)
            {
            _customerDal.Add(customer);
                
            }
        }
    }
}
