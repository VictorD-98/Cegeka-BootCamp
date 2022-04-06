using System;

namespace WebApplicationJwtAuth.Entities
{
    public class CustomerAdd
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public CustomerAdd(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
