using FoodDeliveryApp;
using FoodDeliveryApp.Models;
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

namespace Navegacion_prueba
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Postres : Page
    {

        public Postres()
        {
            ProductosApp p1 = new ProductosApp("Tarta de queso", "Tarta de queso idiazabal cremosa, que nos recuerda a las zonas del norte de España, con una cobertura de confitura.", 5.50, "ms-appx:///Assets/postresTartaqueso.png");
            UControlProducto uc1 = new UControlProducto(p1);
            uc1.Height = 250;
            uc1.Width = 250;
            uc1.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p2 = new ProductosApp("Bola de helado", "Si te quieres refrescar con un sabor veraniego, una tarrina en que tenemos vainilla, chocolate y fresa.", 4.0, "ms-appx:///Assets/postresHelado.png");
            UControlProducto uc2 = new UControlProducto(p2);
            uc2.Height = 250;
            uc2.Width = 250;
            uc2.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p3 = new ProductosApp("Cookie de chocolate", "Deliciosas galletas con pepitas de chocolate al estilo de la abuela.", 3.50, "ms-appx:///Assets/postresCookies.png");
            UControlProducto uc3 = new UControlProducto(p3);
            uc3.Height = 250;
            uc3.Width = 250;
            uc3.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p4 = new ProductosApp("Batido Oreo", "Increible batido con sabor a oreo, mezclado con leche y helado al estilo del BK.", 4.0, "ms-appx:///Assets/postresOreoshake.png");
            UControlProducto uc4 = new UControlProducto(p4);
            uc4.Height = 250;
            uc4.Width = 250;
            uc4.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p5 = new ProductosApp("Batido Caramelo", "Batido al estilo americano, con sabor a caramelo.", 4.0, "ms-appx:///Assets/postresCaramelshake.png");
            UControlProducto uc5 = new UControlProducto(p5);
            uc5.Height = 250;
            uc5.Width = 250;
            uc5.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p6 = new ProductosApp("Brownie", "Bizcocho de chocolate esponjoso con sabor intenso a cacao y crujientes nueces en su interior.",4.50, "ms-appx:///Assets/postresBrowie.png");
            UControlProducto uc6 = new UControlProducto(p6);
            uc6.Height = 250;
            uc6.Width = 250;
            uc6.Margin = new Thickness(10, 10, 10, 10);

            this.InitializeComponent();

            gridView.Items.Add(uc1);
            gridView.Items.Add(uc2);
            gridView.Items.Add(uc3);
            gridView.Items.Add(uc4);
            gridView.Items.Add(uc5);
            gridView.Items.Add(uc6);
        }

        private void irCesta2(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }


        private void irInicio2(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }

        private void gridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var producto = (UControlProducto)e.ClickedItem;

            Frame.Navigate(typeof(PaginaDetalle), producto);
        }

        private void animacionGiro(object sender, PointerRoutedEventArgs e)
        {

            Storyboard sbaux = (Storyboard)this.Resources["giroLogo9"];
            sbaux.Begin();
        }
    }
}
