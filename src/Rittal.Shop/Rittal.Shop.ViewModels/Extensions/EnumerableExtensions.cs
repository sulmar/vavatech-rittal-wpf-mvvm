using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Rittal.Shop.ViewModels.Extensions
{
    public static class EnumerableExtensions
    {
        public static ICollection<T> ToObservableCollection<T>(this IEnumerable<T> items)
        {
            return new ObservableCollection<T>(items);
        }

        
    }

    public class ObservableCollectionEx<T> : ObservableCollection<T>
        where T : INotifyPropertyChanged
    {
        public ObservableCollectionEx(IEnumerable<T> collection, string propertyName, params string[] notifyPropertyName)
            : base(collection)
        {
            foreach (var item in collection)
            {
                item.PropertyChanged += (s, e) =>
                {
                    if (e.PropertyName == propertyName)
                    {
                        //base.OnPropertyChanged(this, new PropertyChangingEventArgs(notifyPropertyName));
                    }
                };
            }
        }
    }
}
