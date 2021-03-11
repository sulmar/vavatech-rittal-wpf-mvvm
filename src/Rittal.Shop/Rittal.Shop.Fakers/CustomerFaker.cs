using Bogus;
using Bogus.Extensions;
using Rittal.Shop.Models;
using System;

namespace Rittal.Shop.Fakers
{
    // Install-Package Bogus

    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Email, f => f.Person.Email);
            RuleFor(p => p.CustomerType, f => f.PickRandom<CustomerType>());
            RuleFor(p => p.Avatar, f => f.Person.Avatar);
            RuleFor(p => p.CreditAmount, f => f.Random.Decimal(1, 1000).OrNull(f, 0.2f) );
            RuleFor(p => p.IsRemoved, f => f.Random.Bool(0.8f));
            RuleFor(p => p.Color, f => f.Commerce.Color());
        }
    }
}
