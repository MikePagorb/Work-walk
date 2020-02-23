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

        private void GO_2_Clicked(object sender, EventArgs e)
        {

        }

        private void GO_3_Clicked(object sender, EventArgs e)
        {

        }

        private void GO_4_Clicked(object sender, EventArgs e)
        {

        }
    }
}