using Newtonsoft.Json;
using pizzaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace pizzaApp
{
    public partial class MainPage : ContentPage
    {
        List<pizza> pizzas;
        string PizzaJson;
        const string URL = "https://drive.google.com/uc?export=download&id=1chXfaxqQCCuEs6qAENsbRrI2v3v98d5c";

        public MainPage()

        {
            InitializeComponent();
            maListView.IsVisible = false;
            waitLayout.IsVisible = true;



            pizzas = new List<pizza>();


            DownloadData();



        }

        public void DownloadData()
        {
            using (var webclient = new WebClient())
            {
                try
                {
                    // PizzaJson = webclient.DownloadString(URL);
                    //foncion asynchrone 
                    webclient.DownloadStringCompleted += (object sender, DownloadStringCompletedEventArgs e) =>
                    {

                        PizzaJson = e.Result;
                        pizzas = JsonConvert.DeserializeObject<List<pizza>>(PizzaJson);

                        maListView.ItemsSource = pizzas;
                        if (maListView.IsRefreshing)
                        {
                            maListView.IsRefreshing = false;
                        }
                        else
                        {
                            maListView.IsVisible = true;
                            waitLayout.IsVisible = false;
                        }


                    };

                    webclient.DownloadStringAsync(new Uri(URL));
                }
                catch (Exception ex)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {

                        DisplayAlert("Erreur", "une erreur reseau" + ex.Message, "ok");
                    });
                    return;
                }


            }
        }

        private void maListView_Refreshing(object s, EventArgs even)
        {
            DownloadData();
        }
    }
}