using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Rittal.Shop.Models
{
    public class Order : BaseEntity
    {
        public string Number { get; set; }
        public ObservableCollection<OrderDetail> Details { get; set; }
        public decimal TotalAmount => Details.Sum(d => d.TotalAmount);

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            Details.Add(orderDetail);
        }

        public Order()
        {
           // Details.CollectionChanged += Details_CollectionChanged;
        }

        //private void Details_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == NotifyCollectionChangedAction.Add )
        //    {
        //        foreach(var item in e.NewItems)
        //        {
        //            item.PropertyChanged += (s, e) =>
        //            {
        //                if (e.PropertyName == nameof(Customer.CreditAmount))
        //                {
        //                    OnPropertyChanged(nameof(TotalCreditAmount));
        //                }
        //            };
        //        }
               
        //    }
        //}
    }

    public class OrderDetail : BaseEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal TotalAmount => Quantity * UnitPrice;

    }

    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
