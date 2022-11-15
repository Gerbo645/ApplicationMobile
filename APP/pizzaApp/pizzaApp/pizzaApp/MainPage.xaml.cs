using pizzaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            pizzas = new List<pizza>();
            pizzas.Add(new pizza { Nom = "Vegetarien", Prix = 5000, Ingrediant = new string[] { "tomate", "poivron", "oignon" } });
            pizzas.Add(new pizza { Nom = "Montagnarde", Prix = 6000, Ingrediant = new string[] { "tomate", "poivron", "oignon", } });
            pizzas.Add(new pizza { Nom = "Carnivor", Prix = 7500, Ingrediant = new string[] { "tomate", "poivron", "oignon", } });
            maListView.ItemsSource = pizzas;
        }
    }
}
