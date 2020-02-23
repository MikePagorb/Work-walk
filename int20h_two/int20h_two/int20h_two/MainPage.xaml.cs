using int20h_two.Views;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace int20h_two
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Register_1 page = new Register_1();
            await Navigation.PushAsync(page);

        }
    }

}
