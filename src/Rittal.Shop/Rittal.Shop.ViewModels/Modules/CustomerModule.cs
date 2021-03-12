using Autofac;
using Bogus;
using Rittal.Shop.Fakers;
using Rittal.Shop.FakeServices;
using Rittal.Shop.IServices;
using Rittal.Shop.Models;
using Rittal.Shop.ViewModels;

namespace Rittal.Shop.ViewModels
{
    public class CustomerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomersViewModel>();
            builder.RegisterType<FakeCustomerService>().As<ICustomerService>();
            builder.RegisterType<CustomerFaker>().As<Faker<Customer>>();
        }
    }
}
