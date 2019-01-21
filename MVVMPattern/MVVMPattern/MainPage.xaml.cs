using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMPattern.ViewModels;
using Xamarin.Forms;

namespace MVVMPattern
{
    public partial class MainPage : ContentPage
    {
        HomeViewModel HomeViewModel;
        public MainPage()
        {
            InitializeComponent();
            HomeViewModel = new HomeViewModel();
            BindingContext = HomeViewModel;
        }
    }
}
