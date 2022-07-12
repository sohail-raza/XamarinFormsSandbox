using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsSandbox.ViewModel
{
    public class MainPageEquipmentViewModel : BindableObject
    {
        public MainPageEquipmentViewModel()
        {
            //Setting something to an Command allows me to get rid of the ugly button_clicked event handlers and pass in my own using data binding
            IncreaseCount = new Command(OnIncrease);
        }
        public ICommand IncreaseCount { get; }


        //This void is used in place of the 
        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} times";
        }

        int count = 0;
        string countDisplay = "Click me";

        //This is used to setup a BindingContext. BindingContexts link two properties together. I can create multiple labels with BindingConten
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;

                countDisplay = value;
                OnPropertyChanged();
            }
        }

    }
}
