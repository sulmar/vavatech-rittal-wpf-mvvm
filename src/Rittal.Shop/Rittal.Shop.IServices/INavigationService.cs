using System;
using System.Collections.Generic;
using System.Text;

namespace Rittal.Shop.IServices
{
    public interface INavigationService 
    {
        void Navigate(string viewName, object parameter = null);

        void GoBack();

        void GoFoward();

        bool CanGoBack { get;  }

        bool CanGoForward { get;  }

        object Parameter { get; }

        string CurrentView{ get;  }
    }
}
