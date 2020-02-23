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
    public partial class Ex2 : ContentPage
    {
        public Ex2()
        {
            //InitializeComponent();
            Image image = new Image();
            image.Source = ImageSource.FromResource("int20h_two.IMG_20200223_064343.png");
            Label label = new Label()
            {
                Text = @"Обхоплюємо праву ногу обома руками та притискаємо до грудей, аналогічно з лівою ногою.Ліву ногу зігніть у коліні і, захопивши стопу рукою, притягніть п`яту до лівої сідниці. При цьому слідкуйте, щоби коліна торкалися один одного, а спина залишалася прямою. Утримуйте рівновагу.",
                TextColor = Color.Azure,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center


            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { image, label }
            };
            Content = stackLayout;
            BackgroundColor = Color.DarkBlue;
        }
    }
}