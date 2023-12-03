using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.Context;
using Test2.Models;

namespace Test2.ViewModels
{
    public class CartWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Product> CartList { get; set; }


        public CartWindowViewModel()
        {
            CartList = new ObservableCollection<Product>();
            InitializeData();
        }

        public void InitializeData()
        {
            using (var context = new Test2Context())
            {
                CartList = new ObservableCollection<Product>(context.Products);
            }
        }
    }
}
