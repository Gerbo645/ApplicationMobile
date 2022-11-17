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

        public MainPage()
            
        {
            InitializeComponent();
            maListView.IsVisible= false;
            waitLayout.IsVisible=true;
        
        
            

            pizzas = new List<pizza>();

           
            const string URL = "https://drive.google.com/uc?export=download&id=1chXfaxqQCCuEs6qAENsbRrI2v3v98d5c";
            string PizzaJson = "";
           

            using (var webclient = new WebClient())
            {
                try
                {
                    Console.WriteLine("etape 2");
                    // PizzaJson = webclient.DownloadString(URL);
                    //foncion asynchrone 
                    webclient.DownloadStringCompleted += (object sender, DownloadStringCompletedEventArgs e) => 
                    {
                       
                        PizzaJson =e.Result;
                        pizzas = JsonConvert.DeserializeObject<List<pizza>>(PizzaJson);

                        maListView.ItemsSource = pizzas;
                        maListView.IsVisible = true;
                        waitLayout.IsVisible = false;

                    };
                    
                    webclient.DownloadStringAsync(new Uri(URL));
                }
                catch(Exception ex)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {

                        DisplayAlert("Erreur", "une erreur reseau" + ex.Message, "ok");
                    });
                    return;
                }

             
            }
            


        }
    }
}
