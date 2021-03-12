using Autofac;
using Bogus;
using Rittal.Shop.Fakers;
using Rittal.Shop.FakeServices;
using Rittal.Shop.IServices;
using Rittal.Shop.Models;
using Rittal.Shop.ViewModels;
using Rittal.Shop.WPFClient.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rittal.Shop.WPFClient
{
    public class ViewModelLocator
    {
        // Install-Package AutoFac

        private readonly IContainer container;

        public ViewModelLocator()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();

            //containerBuilder.RegisterType<CustomersViewModel>();
            //containerBuilder.RegisterType<FakeCustomerService>().As<ICustomerService>();
            //containerBuilder.RegisterType<CustomerFaker>().As<Faker<Customer>>();

            containerBuilder.RegisterModule(new CustomerModule());


            // Automatyczna rejestracja wszystkich klas, które dziedziczą po BaseViewModel
            //containerBuilder.RegisterAssemblyTypes(typeof(BaseViewModel).Assembly)
            //         .Where(t => t.IsSubclassOf(typeof(BaseViewModel)));
            
            containerBuilder.RegisterType<ShellViewModel>().SingleInstance();



            container = containerBuilder.Build();

        }

        // public CustomersViewModel CustomersViewModel => new CustomersViewModel(new FakeCustomerService(new CustomerFaker()));
        public CustomersViewModel CustomersViewModel => container.Resolve<CustomersViewModel>();
        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();
    }
}
