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
    public partial class Register_2 : ContentPage
    {
        private  int weight =0 ;
        private  int age = 0;
        public Register_2(string weight, string age)
        {
            InitializeComponent();
            this.weight = int.Parse( weight);
            this.age = int.Parse( age);


        }

        private void prob_Done_button_Clicked(object sender, EventArgs e)
        {
           

        }
    }
}