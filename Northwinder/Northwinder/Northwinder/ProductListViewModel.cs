using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwinder
{
    public class ProductListViewModel
    {
        public ProductListViewModel(IEnumerable<Product> products = null)
        {
            Products = new ObservableCollection<Product>();
            if (products != null) foreach (var p in products) Products.Add(p);
        }

        public ObservableCollection<Product> Products { get; set; }
    }
}
