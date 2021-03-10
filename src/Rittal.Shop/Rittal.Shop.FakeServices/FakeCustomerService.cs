using Bogus;
using Rittal.Shop.Fakers;
using Rittal.Shop.IServices;
using Rittal.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rittal.Shop.FakeServices
{
    public class FakeCustomerService : ICustomerService
    {
        private readonly ICollection<Customer> customers;

        public FakeCustomerService()
            : this(new CustomerFaker())
        {
        }

        public FakeCustomerService(Faker<Customer> faker)
        {
            customers = faker.Generate(100);

        }

        public void Add(Customer entity)
        {
            customers.Add(entity);
        }

        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        public Customer Get(int id)
        {
            return customers.SingleOrDefault(c => c.Id == id);
        }

        public void Remove(int id)
        {
            customers.Remove(Get(id));
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
