using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Northwinder
{
    public partial class ProductPage : ContentPage
    {
        private Product _product; 

        public ProductPage(Product product)
        {
            InitializeComponent();

            _product = product;
            BindingContext = _product;
        }
    }
}
