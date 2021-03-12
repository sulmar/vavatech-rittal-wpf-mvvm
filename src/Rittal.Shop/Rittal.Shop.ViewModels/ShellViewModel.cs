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
        private INavigationService navigationService;

        //public ICommand ShowCustomersCommand { get; private set; }
        //public ICommand ShowOrdersCommand { get; private set; }
        //public ICommand ShowProductsCommand { get; private set; }

        public ICommand ShowViewCommand { get; private set; }

        public INavigationService NavigationService { get; set; }

        public ShellViewModel(INavigationService navigationService)
        {
            //ShowCustomersCommand = new DelegateCommand(ShowCustomers, CanShowCustomers);
            //ShowOrdersCommand = new DelegateCommand(ShowOrders);
            //ShowProductsCommand = new DelegateCommand(ShowProducts);

            // ShowViewCommand = new DelegateCommand<string>(ShowView);

            // ShowViewCommand = new DelegateCommand<string>(viewName => navigationService.Navigate(viewName));

            ShowViewCommand = new DelegateCommand<string>(viewName => NavigationService.Navigate($"{viewName}View.xaml"));

            this.NavigationService = navigationService;

            NavigationService.Navigate($"CustomersView.xaml");
        }

        //public void ShowView(string viewName)
        //{
        //    navigationService.Navigate(viewName);
        //}

        //public void ShowCustomers()
        //{
        //    navigationService.Navigate("customers");
        //}

        //public bool CanShowCustomers()
        //{
        //    return true;
        //}


        //public void ShowOrders()
        //{
        //    navigationService.Navigate("orders");
        //}

        //public void ShowProducts()
        //{
        //    navigationService.Navigate("products");
        //}
    }
}
