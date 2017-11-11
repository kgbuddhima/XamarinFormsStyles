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
    public partial class InlineStylingSample : ContentPage
    {
        public InlineStylingSample()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}