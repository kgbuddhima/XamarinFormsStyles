using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StyleDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLevelStyles : ContentPage
    {
        public PageLevelStyles()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            var buttonStyle = new Style(typeof(Button));
            buttonStyle.Setters.Add(BackgroundColorProperty, Color.Maroon);
            buttonStyle.Setters.Add(new Setter { Property = Button.TextColorProperty, Value = Color.White });
            buttonStyle.Setters.Add(HeightRequestProperty, "75");
            buttonStyle.Setters.Add(new Setter { Property = Button.VerticalOptionsProperty, Value = LayoutOptions.FillAndExpand });
            buttonStyle.Setters.Add(new Setter { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand });

            Resources["buttonStyleCalculator"] = buttonStyle;
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            var buttonStyle = new Style(typeof(Button));
            buttonStyle.Setters.Add(BackgroundColorProperty, Color.BlueViolet);
            buttonStyle.Setters.Add(new Setter { Property = Button.TextColorProperty, Value = Color.White });
            buttonStyle.Setters.Add(HeightRequestProperty, "75");
            buttonStyle.Setters.Add(Button.VerticalOptionsProperty, LayoutOptions.FillAndExpand);
            buttonStyle.Setters.Add(new Setter { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand });

            Resources["buttonStyleCalculator"] = buttonStyle;
        }
    }
}