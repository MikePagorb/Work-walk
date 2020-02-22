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
        public Register_1()
        {
            InitializeComponent();
        }

        private async void Done_Clicked(object sender, EventArgs e)
        {
            Register_2 page = new Register_2();
            await Navigation.PushAsync(page);
        }
    }
}