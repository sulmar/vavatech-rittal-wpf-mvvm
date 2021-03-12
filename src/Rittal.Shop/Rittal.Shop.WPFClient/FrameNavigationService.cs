using Rittal.Shop.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Rittal.Shop.WPFClient
{

    public class FrameNavigationService : INavigationService
    {
        private Frame frame;

        public bool CanGoBack => throw new NotImplementedException();

        public bool CanGoForward => throw new NotImplementedException();

        public object Parameter => throw new NotImplementedException();

        public string CurrentView => throw new NotImplementedException();

        public void GoBack()
        {
            frame.GoBack();
        }

        public void GoFoward()
        {
            frame.GoForward();
        }

        public void Navigate(string viewName, object parameter = null)
        {
            frame = Get("MainFrame");

            Uri uri = new Uri($"Views/{viewName}View.xaml", UriKind.Relative);

            frame.Navigate(uri, parameter);
        }

        private Frame Get(string name)
        {            
            if (Application.Current.MainWindow.FindName(name) is Frame frame)
            {
                return frame;
            }

            throw new KeyNotFoundException(nameof(name));
        }
    }
}
