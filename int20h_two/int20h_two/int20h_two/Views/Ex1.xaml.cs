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
    public partial class Ex1 : ContentPage
    {
        public Ex1()
        {
            //InitializeComponent();
            Image image = new Image();
            image.Source = ImageSource.FromResource("int20h_two.IMG_20200223_034923.png");
            Label label = new Label()
            {
                Text = @"Нахили голови
Починайте нахили головою з лівого вуха в напрямку лівого плеча, обережно опускайте підборіддя до грудей, поті ідіть до правого вуха та правого плеча.
Зробіть паузу на повторіть вправу в протилежний бік. Якщо відчуваєте різкий біль, припиніть повороти",
                TextColor = Color.Azure,
                HorizontalTextAlignment=TextAlignment.Center,
                VerticalTextAlignment=TextAlignment.Center
             
                
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { image,label }
            };
            Content = stackLayout;
            BackgroundColor = Color.DarkBlue;      
        }
    }
}