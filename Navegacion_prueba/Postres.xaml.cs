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
            ProductosApp p1 = new ProductosApp("Tarta de queso", "descripcion descripcion descripcion", 4.50, "ms-appx:///Assets/postres.png");
            UControlProducto uc1 = new UControlProducto(p1);
            uc1.Height = 250;
            uc1.Width = 250;
            uc1.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p2 = new ProductosApp("Bola de helado", "descripcion descripcion descripcion", 4.50, "ms-appx:///Assets/postres.png");
            UControlProducto uc2 = new UControlProducto(p2);
            uc2.Height = 250;
            uc2.Width = 250;
            uc2.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p3 = new ProductosApp("Cookie de chocolate", "descripcion descripcion descripcion", 4.50, "ms-appx:///Assets/postres.png");
            UControlProducto uc3 = new UControlProducto(p3);
            uc3.Height = 250;
            uc3.Width = 250;
            uc3.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p4 = new ProductosApp("Batido Oreo", "descripcion descripcion descripcion", 4.50, "ms-appx:///Assets/postres.png");
            UControlProducto uc4 = new UControlProducto(p4);
            uc4.Height = 250;
            uc4.Width = 250;
            uc4.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p5 = new ProductosApp("Batido Caramelo", "descripcion descripcion descripcion", 4.50, "ms-appx:///Assets/postres.png");
            UControlProducto uc5 = new UControlProducto(p5);
            uc5.Height = 250;
            uc5.Width = 250;
            uc5.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp p6 = new ProductosApp("Brownie", "descripcion descripcion descripcion",4.50, "ms-appx:///Assets/postres.png");
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

        private void irAboutUs2(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SobreNosotros));
        }

        private void gridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var producto = (UControlProducto)e.ClickedItem;

            Frame.Navigate(typeof(PaginaDetalle), producto);
        }
    }
}
