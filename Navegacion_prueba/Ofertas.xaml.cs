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
            ProductosApp m1 = new ProductosApp("Oferta 1", "The Queen + patatas deluxe.", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UCofertMenus uc1 = new UCofertMenus(m1);
            uc1.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m2 = new ProductosApp("Oferta 2", "The Queen + patatas deluxe.", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UCofertMenus uc2 = new UCofertMenus(m2);
            uc2.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m3 = new ProductosApp("Oferta 3", "The Queen + patatas deluxe.", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UCofertMenus uc3 = new UCofertMenus(m3);
            uc3.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m4 = new ProductosApp("Oferta 4", "The Queen + patatas deluxe.", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UCofertMenus uc4 = new UCofertMenus(m4);
            uc4.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m5 = new ProductosApp("Oferta 5", "The Queen + patatas deluxe.", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UCofertMenus uc5 = new UCofertMenus(m5);
            uc5.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m6 = new ProductosApp("Oferta 6", "The Queen + patatas deluxe.", 4.50, "ms-appx:///Assets/hamburguesa1.png");
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

        private void irAboutUs8(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SobreNosotros));
        }

        private void listView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = e.ClickedItem;
            this.Frame.Navigate(typeof(PaginaDetalle));
        }
    }
}
