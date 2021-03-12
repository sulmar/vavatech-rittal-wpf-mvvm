using Rittal.Common;
using Rittal.Shop.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Rittal.Shop.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;

        public ICommand ShowCustomersCommand { get; private set; }
        public ICommand ShowOrdersCommand { get; private set; }
        public ICommand ShowProductsCommand { get; private set; }

        public ShellViewModel(INavigationService navigationService)
        {
            ShowCustomersCommand = new DelegateCommand(ShowCustomers, CanShowCustomers);
            ShowOrdersCommand = new DelegateCommand(ShowOrders);
            ShowProductsCommand = new DelegateCommand(ShowProducts);
            this.navigationService = navigationService;
        }

        public void ShowCustomers()
        {
            navigationService.Navigate("customers");
        }

        public bool CanShowCustomers()
        {
            return true;
        }


        public void ShowOrders()
        {
            navigationService.Navigate("orders");
        }

        public void ShowProducts()
        {
            navigationService.Navigate("products");
        }
    }
}
