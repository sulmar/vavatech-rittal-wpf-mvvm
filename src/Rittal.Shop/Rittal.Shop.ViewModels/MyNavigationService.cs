using Rittal.Shop.IServices;
using Rittal.Shop.Models;
using System;

namespace Rittal.Shop.ViewModels
{
    public class MyNavigationService : Base, INavigationService
    {
        private string currentView;

        public bool CanGoBack => throw new NotImplementedException();

        public bool CanGoForward => throw new NotImplementedException();

        public object Parameter => throw new NotImplementedException();

        public string CurrentView
        {
            get => currentView; 
            private set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

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
