using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationJwtAuth.Entities;
//using WebApplicationJwtAuth.Entities.Deposits;
//using WebApplicationJwtAuth.Entities.Requests;

namespace WebApplicationJwtAuth.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            DepositCustomer.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return DepositCustomer.GetAll();
        }
    }
}
