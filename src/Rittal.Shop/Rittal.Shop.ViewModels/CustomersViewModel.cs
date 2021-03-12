using Rittal.Common;
using Rittal.Shop.Fakers;
using Rittal.Shop.FakeServices;
using Rittal.Shop.IServices;
using Rittal.Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Rittal.Shop.ViewModels.Extensions;
using System.Linq;

namespace Rittal.Shop.ViewModels
{

   

    public class CustomersViewModel : BaseViewModel
    {
        public ICollection<Customer> Customers { get; private set; }

        public Customer SelectedCustomer { get; set; }

        private readonly ICustomerService customerService;

        public string Message { get; set; }

        public bool IsOverLimit => SelectedCustomer?.CreditAmount > 400;


        public ICommand SendCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }

        public ICommand AddCustomerCommand { get; set; }


        public decimal TotalCreditAmount => Customers.Where(c=>c.CreditAmount.HasValue).Sum(c => c.CreditAmount.Value);

        public CustomersViewModel()
            : this(new FakeCustomerService())
        {

        }

        public CustomersViewModel(ICustomerService customerService)
        {
            SendCommand = new DelegateCommand(Send);
            SaveCommand = new DelegateCommand(Save);
            AddCustomerCommand = new DelegateCommand(AddCustomer);

            this.customerService = customerService;

            Load();
        }

        private void Load()
        {
            Customers = customerService.Get().ToObservableCollection();

            //foreach (var customer in Customers)
            //{
            //    customer.PropertyChanged += (s, e) =>
            //    {
            //        if (e.PropertyName == nameof(Customer.CreditAmount))
            //        {
            //            OnPropertyChanged(nameof(TotalCreditAmount));
            //        }
            //    };
            //}

            Message = "Hello World!";
        }

        public void Send()
        {
            Trace.WriteLine($"Send message to {SelectedCustomer.FullName}");
        }


        public void Save()
        {
            SelectedCustomer.FirstName = "John";
            SelectedCustomer.LastName = "Smith";
        }

        public void AddCustomer()
        {
            CustomerFaker customerFaker = new CustomerFaker();
            Customer customer = customerFaker.Generate();

            Customers.Add(customer);
        }
    }
}
