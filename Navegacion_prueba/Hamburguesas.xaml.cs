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
using FoodDeliveryApp.Models;
using FoodDeliveryApp;
using Newtonsoft.Json;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Navegacion_prueba
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Hamburguesas : Page
    {

        public Hamburguesas()
        {
            ProductosApp h1 = new ProductosApp("Cheese Please","Hambuguesa destinada especialmente para los amantes del queso, con increible cantidad de cheddar.", 7.50, false, "ms-appx:///Assets/hamburguesaqueso.png");
            UControlProducto uc1 = new UControlProducto(h1);
            uc1.Height = 250;
            uc1.Width = 250;
            uc1.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp h2 = new ProductosApp("Imperial", "Para los mayores demoradores de cada casa, se incluyen todos los ingredientes disponibles en el local.", 9.50, false, "ms-appx:///Assets/hamburguesadobreCarne.png");
            UControlProducto uc2 = new UControlProducto(h2);
            uc2.Height = 250;
            uc2.Width = 250;
            uc2.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp h3 = new ProductosApp("Bacon Love", "Hamburguesa anormal debido a su extraordinario sabor a bacon debido a todo el que incluye.", 8.50, false, "ms-appx:///Assets/baconHamburguesa.png");
            UControlProducto uc3 = new UControlProducto(h3);
            uc3.Height = 250;
            uc3.Width = 250;
            uc3.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp h4 = new ProductosApp("Monteverde", "Esta hamburguesa es para la gente que opta por una opción más ligera con mayor cantidad de lechuga.", 6.50, false, "ms-appx:///Assets/hamburguesamonteVerde.png");
            UControlProducto uc4 = new UControlProducto(h4);
            uc4.Height = 250;
            uc4.Width = 250;
            uc4.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp h5 = new ProductosApp("Burguer Bros", "Hamburguesa destina a los amantes del picante, ya que incluye pepinillos encurtidos en chile delicioso.", 9.50, false, "ms-appx:///Assets/hamburguesaCarnePepino.png");
            UControlProducto uc5 = new UControlProducto(h5);
            uc5.Height = 250;
            uc5.Width = 250;
            uc5.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp h6 = new ProductosApp("Chicken Crunchy", "La opción idónea para los amantes del pollo en la hamburguesa.", 7.50, false, "ms-appx:///Assets/hamburguesa1.png");
            UControlProducto uc6 = new UControlProducto(h6);
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

        private void irCesta1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irInicio1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }

        public void gridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //String cadena = "Hola que tal";

            var producto = (UControlProducto) e.ClickedItem;

            Frame.Navigate(typeof(PaginaDetalle), producto);
        }
    }
}
