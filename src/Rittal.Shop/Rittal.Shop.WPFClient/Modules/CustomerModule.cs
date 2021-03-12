using Autofac;
using Bogus;
using Rittal.Shop.Fakers;
using Rittal.Shop.FakeServices;
using Rittal.Shop.IServices;
using Rittal.Shop.Models;
using Rittal.Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rittal.Shop.WPFClient.Modules
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
