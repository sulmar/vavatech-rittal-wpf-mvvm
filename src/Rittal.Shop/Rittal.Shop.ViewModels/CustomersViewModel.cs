using Rittal.Shop.FakeServices;
using Rittal.Shop.IServices;
using Rittal.Shop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rittal.Shop.ViewModels
{

    public class CustomersViewModel : BaseViewModel
    {
        public IEnumerable<Customer> Customers { get; private set; }

        public Customer SelectedCustomer { get; set; }

        private readonly ICustomerService customerService;

        public CustomersViewModel()
            : this(new FakeCustomerService())
        {

        }

        public CustomersViewModel(ICustomerService customerService)
        {
            this.customerService = customerService;

            Load();
        }

        private void Load()
        {
            Customers = customerService.Get();
        }

        public void Send()
        {
            Trace.WriteLine($"Send message to {SelectedCustomer.FullName}");
        }
    }
}
