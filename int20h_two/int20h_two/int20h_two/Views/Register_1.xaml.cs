using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace int20h_two.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register_1 : ContentPage

    {
        private int weight;
        private int age;
        public Register_1()
        {
            InitializeComponent();
        }

        private async void Done_Clicked(object sender, EventArgs e)
        {
            if(!int.TryParse(weight_entry.Text, out weight) || !int.TryParse(age_entry.Text, out age))
            {
                await DisplayAlert("Alert", "Write integer", "Ok");
            } 
            Register_2 page = new Register_2(weight_entry.Text, age_entry.Text);
            await Navigation.PushAsync(page);
        }
    }
}