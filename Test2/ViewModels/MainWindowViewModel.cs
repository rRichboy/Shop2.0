using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Npgsql;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Test2.Context;
using Test2.Models;

namespace Test2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Product> Products { get; set; }


        public MainWindowViewModel()
        {
            InitializeData();
        }

        public void InitializeData()
        {
            using (var context = new Test2Context())
            {
                Products = new ObservableCollection<Product>(context.Products);
            }
        }
    }
}