using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Northwinder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ProductListPage());
        }

        protected async override void OnStart()
        {
            var r = new Repository();
            var products = await r.GetAllProducts();

            MessagingCenter.Send<App, List<Product>>(this, "ProductsLoaded", products);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
