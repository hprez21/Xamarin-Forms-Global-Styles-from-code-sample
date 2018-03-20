using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App15.Helpers
{
    public class ResourcesDemo : Application
    {
        public ResourceDictionary resources;
        // Fondo negro
        public Style contentBack = new Style(typeof(StackLayout))
        {
            Setters =
            {
                    new Setter{Property=ContentPage.BackgroundColorProperty,Value=Color.Black}
            }
        };
        // Boton transparente
        public Style btnWhiteTrans = new Style(typeof(Button))
        {
            Setters =
            {
                new Setter{Property=Button.BackgroundColorProperty,Value=Color.FromRgba(255,255,255,90)},
                new Setter{Property=Button.TextColorProperty,Value=Color.White},
                new Setter{Property=Button.BorderRadiusProperty,Value=30}
            }
        };
        // Campos Entry
        public Style styleEntries = new Style(typeof(Entry))
        {
            Setters =
            {
                new Setter{Property=Entry.BackgroundColorProperty,Value=Color.FromRgba(255,255,255,90)},
                new Setter{Property=Entry.TextColorProperty,Value=Color.White}
            }
        };
        // Constructor de la clase
        public ResourcesDemo()
        {
            Resources = new ResourceDictionary();
            Resources.Add(contentBack);
            Resources.Add(btnWhiteTrans);
            Resources.Add(styleEntries);
            MainPage = new App15.MainPage();

        }
    }
}