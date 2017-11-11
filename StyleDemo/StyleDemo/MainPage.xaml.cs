using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StyleDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnNoStylePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.NoStylesSample());
        }

        private void btnInlineStylePage_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new Views.InlineStylingSample());
        }

        private void btnStylesInPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.PageLevelStyles());
        }

        private void btnImplicitStylePage_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new Views.ImplicitStyleSample());
        }
    }
}
