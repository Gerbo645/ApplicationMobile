using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms;

namespace pizzaApp.Model
{
    public class pizza
    {
        public string nom { get; set; }
        public int prix { get; set; }
         public string[] ingredients { get; set; }
        public string PrixDevise { get { return prix + "FCFA"; }  }


    public string ListIgrediant { get { return string.Join(",", ingredients); } }

    public string imageUrl { get; set; }

      

        public pizza()
             
        {
        
        }

    }

} 



