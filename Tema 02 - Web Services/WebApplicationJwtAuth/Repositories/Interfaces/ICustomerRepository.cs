using WebApplicationJwtAuth.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationJwtAuth.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAllCustomers();
        public void AddCustomer(Customer customer);
    }
}
