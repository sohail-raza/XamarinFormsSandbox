using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsSandbox.ViewModel;

namespace XamarinFormsSandbox
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //bought in the view model from another class 
            BindingContext = new MainPageEquipmentViewModel();
        }


    }
}
