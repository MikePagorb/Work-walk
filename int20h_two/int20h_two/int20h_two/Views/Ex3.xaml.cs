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
    public partial class Ex3 : ContentPage
    {
        public Ex3()
        {
            //InitializeComponent();
            Image image = new Image();
            image.Source = ImageSource.FromResource("int20h_two.IMG_20200223_034901.png");
            Label label = new Label()
            {
                Text = @"Розтяжки м'язів плечей
Обхопіть праву руку вище ліктя лівої, притисніть її до тіла й випряміть, опустітть праве плече вниз. Лівою рукою тягніть праву вгору, піднімаючи її ліктем.
Відчуйте напругу в задній частині плечей.",
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