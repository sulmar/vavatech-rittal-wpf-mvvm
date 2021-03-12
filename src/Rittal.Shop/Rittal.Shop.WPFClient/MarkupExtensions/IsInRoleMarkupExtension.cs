using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Rittal.Shop.WPFClient.MarkupExtensions
{
    public class UserNameMarkupExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Environment.UserName;
        }
    }
}
