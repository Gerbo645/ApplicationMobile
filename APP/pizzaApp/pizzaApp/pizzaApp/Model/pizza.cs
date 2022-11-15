using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms;

namespace pizzaApp.Model
{
    public class pizza
    {
        public string Nom { get; set; }
        public int Prix { get; set; }
         public string[] Ingrediant { get; set; }
        public string PrixDevise { get { return Prix + "FCFA"; }  }

    public string ListIgrediant { get { return string.Join(",", Ingrediant); } }


       

        public pizza()
             
        {
        
        }

    }
   
      
}
