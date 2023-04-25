using System;
using System.Linq.Expressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bromeroS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
