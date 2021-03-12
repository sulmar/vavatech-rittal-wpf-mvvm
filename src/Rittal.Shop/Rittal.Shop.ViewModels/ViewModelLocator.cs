using Autofac;
using Rittal.Shop.IServices;

namespace Rittal.Shop.ViewModels
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

            //  containerBuilder.RegisterType<FrameNavigationService>().As<INavigationService>().SingleInstance();

            containerBuilder.RegisterType<MyNavigationService>().As<INavigationService>().SingleInstance();

            container = containerBuilder.Build();

        }

        // public CustomersViewModel CustomersViewModel => new CustomersViewModel(new FakeCustomerService(new CustomerFaker()));
        public CustomersViewModel CustomersViewModel => container.Resolve<CustomersViewModel>();
        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();
    }
}
