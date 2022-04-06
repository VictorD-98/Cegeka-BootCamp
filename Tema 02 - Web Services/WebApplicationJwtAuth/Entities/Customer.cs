using System;

namespace WebApplicationJwtAuth.Entities

{
    public class Customer
    {
        public static int id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer() { }

        public Customer(CustomerAdd customer)
        {
            Id = id;
            Name = customer.Name;
            Surname = customer.Surname;

            id++;
        }
    }
}