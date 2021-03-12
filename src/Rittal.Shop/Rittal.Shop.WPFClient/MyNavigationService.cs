using Rittal.Shop.IServices;
using System;

namespace Rittal.Shop.WPFClient
{
    public class MyNavigationService : INavigationService
    {
       
        public bool CanGoBack => throw new NotImplementedException();

        public bool CanGoForward => throw new NotImplementedException();

        public object Parameter => throw new NotImplementedException();

        public string CurrentView { get; private set; }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void GoFoward()
        {
            throw new NotImplementedException();
        }

        public void Navigate(string viewName, object parameter = null)
        {
            CurrentView = viewName;
        }
    }
}
