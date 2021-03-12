using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Rittal.Shop.WPFClient.Behaviors
{

    // Install-Package Microsoft.Xaml.Behaviors.Wpf
    public class ButtonBehavior : Behavior<Button>
    {
        // public Double Width { get; set; }

        public Double Width
        {
            get { return (Double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Width.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register(nameof(Width), typeof(Double), typeof(ButtonBehavior), new PropertyMetadata(0d));


        protected override void OnAttached()
        {
            Button button = this.AssociatedObject;

            button.MouseEnter += Button_MouseEnter;
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            AssociatedObject.Width += Width;
        }
    }
}
