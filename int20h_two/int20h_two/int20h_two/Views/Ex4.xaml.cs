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
    public partial class Ex4 : ContentPage
    {
        public Ex4()
        {
            //InitializeComponent();
            Image image = new Image();
            image.Source = ImageSource.FromResource("int20h_two.IMG_20200223_034839.png");
            Label label = new Label()
            {
                Text = @"Ростягивание трицепса
Одну зігнуту руку розташуйте так, щоб долоня була на рівні основи шиї, а другою рукою тримайтесь за лікоть і потяніть до відчуття розтягнення трицепсів (в задній частині плеча)",
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