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
    public partial class ExersizesList : ContentPage
    {
        public ExersizesList(string index)
        {
            InitializeComponent();
            
        }

        private async void GO_1_Clicked(object sender, EventArgs e)
        {
            Ex1 page1 = new Ex1();
            await Navigation.PushAsync(page1);
        }

        private async void GO_2_Clicked(object sender, EventArgs e)
        {
            Ex2 page2 = new Ex2();
            await Navigation.PushAsync(page2);
        }

        private async void GO_3_Clicked(object sender, EventArgs e)
        {
            Ex3 page2 = new Ex3();
            await Navigation.PushAsync(page2);
        }

        private async void GO_4_Clicked(object sender, EventArgs e)
        {
            Ex4 page2 = new Ex4();
            await Navigation.PushAsync(page2);
        }
    }
}