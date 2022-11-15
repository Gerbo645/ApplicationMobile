using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pizzaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
           MainPage.BackgroundColor = Color.FromHex("#1abbd4");
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
