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
            var barredenavigation = new NavigationPage(new MainPage());
            barredenavigation.BarBackgroundColor = Color.FromHex("#10bbd4");
            MainPage = barredenavigation;
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
