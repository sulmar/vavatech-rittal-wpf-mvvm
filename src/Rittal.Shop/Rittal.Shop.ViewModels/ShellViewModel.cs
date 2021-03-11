using Rittal.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Rittal.Shop.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public ICommand ShowCustomersCommand { get; private set; }
        public ICommand ShowOrdersCommand { get; private set; }
        public ICommand ShowProductsCommand { get; private set; }

        public ShellViewModel()
        {
            ShowCustomersCommand = new DelegateCommand(ShowCustomers, CanShowCustomers);
            ShowOrdersCommand = new DelegateCommand(ShowOrders);
            ShowProductsCommand = new DelegateCommand(ShowProducts);
        }

        public void ShowCustomers()
        {

        }

        public bool CanShowCustomers()
        {
            return true;
        }


        public void ShowOrders()
        {

        }

        public void ShowProducts()
        {

        }
    }
}
