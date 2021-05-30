using FoodDeliveryApp.Models;
using Navegacion_prueba;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace FoodDeliveryApp
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Ofertas : Page
    {
      
        public Ofertas()
        {
            ProductosApp m1 = new ProductosApp("B16 Snacks Lovers", "Bolas de queso + patatas deluxe.", 7.0, false, "ms-appx:///Assets/snacksBolasquesos.png");
            UCofertMenus uc1 = new UCofertMenus(m1);
            uc1.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m2 = new ProductosApp("A32 Sugar Destroyers", "Helado + cookies de chocolate.", 6.0, false, "ms-appx:///Assets/postresHelado.png");
            UCofertMenus uc2 = new UCofertMenus(m2);
            uc2.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m3 = new ProductosApp("C3 Chicken Crunchyx2", "2 Chicken Crunchy", 13.0, false, "ms-appx:///Assets/hamburguesa1.png");
            UCofertMenus uc3 = new UCofertMenus(m3);
            uc3.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m4 = new ProductosApp("B12 Pizza Lovers", "Pizza Campina + pizza cabramelizada.", 12.0, false, "ms-appx:///Assets/pizzacampina.png");
            UCofertMenus uc4 = new UCofertMenus(m4);
            uc4.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m5 = new ProductosApp("A42 Oferta del día", "Fingers de queso", 2.0, false, "ms-appx:///Assets/snacksFinger.png");
            UCofertMenus uc5 = new UCofertMenus(m5);
            uc5.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m6 = new ProductosApp("Z18 Completito", "Imperial + patatas deluxe.", 11.0, false, "ms-appx:///Assets/hamburguesadobreCarne.png");
            UCofertMenus uc6 = new UCofertMenus(m6);
            uc6.Margin = new Thickness(0, 10, 0, 10);


            this.InitializeComponent();

            listView.Items.Add(uc1);
            listView.Items.Add(uc2);
            listView.Items.Add(uc3);
            listView.Items.Add(uc4);
            listView.Items.Add(uc5);
            listView.Items.Add(uc6);
        }

        private void irCesta8(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irInicio8(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }

        private void animacionGiro(object sender, PointerRoutedEventArgs e)
        {

            Storyboard sbaux = (Storyboard)this.Resources["giroLogo6"];
            sbaux.Begin();
        }
    }
}
