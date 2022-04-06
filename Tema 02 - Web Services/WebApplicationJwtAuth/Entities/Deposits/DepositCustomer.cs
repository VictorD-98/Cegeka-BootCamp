using System.Collections.Generic;
using System;

namespace WebApplicationJwtAuth.Entities
{
    public class DepositCustomer
    {
        private static List<Customer> storage = new List<Customer>();
        public static void Add(Customer item)
        {
            storage.Add(item);
        }
        public static List<Customer> GetAll()
        {
            return storage;
        }
        public static Customer GetCustomer(int id)
        {
            Customer toReturn = new Customer();
            for (int i = 0; i < storage.Count; i++)
            {
                if (storage[i].Id == id)
                {
                    toReturn = storage[i];
                }
            }
            return toReturn;
        }
    }
}
