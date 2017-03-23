using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Northwinder
{
    public partial class ProductListPage : ContentPage
    {
        private ProductListViewModel _pvm;

        public ProductListPage()
        {
            InitializeComponent();
            listView.IsRefreshing = true;

            MessagingCenter.Subscribe<App, List<Product>>(this, "ProductsLoaded", (sender, arg) => {
                var r = new Repository();
                _pvm = new ProductListViewModel(arg);
                BindingContext = _pvm;
                listView.IsRefreshing = false;
            });
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var product = e.SelectedItem as Product;
            if (product != null) {
                listView.SelectedItem = null;
                await Navigation.PushAsync(new ProductPage(product));
            }
        }
    }
}
