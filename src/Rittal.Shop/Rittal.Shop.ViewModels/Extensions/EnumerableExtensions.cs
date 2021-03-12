using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Rittal.Shop.ViewModels.Extensions
{
    public static class EnumerableExtensions
    {
        public static ICollection<T> ToObservableCollection<T>(this IEnumerable<T> items)
        {
            return new ObservableCollection<T>(items);
        }


        public static BindingList<T> ToBindingList<T>(this IEnumerable<T> collection)
        {
            return new BindingList<T>(collection.ToList());
        }
    }
}
