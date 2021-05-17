﻿using System;
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
            ProductosApp h1 = new ProductosApp("Cheese Please", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UControlProducto uc1 = new UControlProducto(h1);
            uc1.Height = 250;
            uc1.Width = 250;
            uc1.Margin = new Thickness(20, 20, 10, 10);

            ProductosApp h2 = new ProductosApp("Monteverde", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UControlProducto uc2 = new UControlProducto(h2);
            uc2.Height = 250;
            uc2.Width = 250;
            uc2.Margin = new Thickness(20, 20, 10, 10);

            ProductosApp h3 = new ProductosApp("De la Casa", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UControlProducto uc3 = new UControlProducto(h3);
            uc3.Height = 250;
            uc3.Width = 250;
            uc3.Margin = new Thickness(20, 20, 10, 10);

            ProductosApp h4 = new ProductosApp("Imperial", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UControlProducto uc4 = new UControlProducto(h4);
            uc4.Height = 250;
            uc4.Width = 250;
            uc4.Margin = new Thickness(20, 20, 10, 10);

            ProductosApp h5 = new ProductosApp("Burguer Bros", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UControlProducto uc5 = new UControlProducto(h5);
            uc5.Height = 250;
            uc5.Width = 250;
            uc5.Margin = new Thickness(20, 20, 10, 10);

            ProductosApp h6 = new ProductosApp("The King", 4.50, "ms-appx:///Assets/hamburguesa1.png");
            UControlProducto uc6 = new UControlProducto(h6);
            uc6.Height = 250;
            uc6.Width = 250;
            uc6.Margin = new Thickness(20, 20, 10, 10);

            this.InitializeComponent();

            wrapPanel.Children.Add(uc1);
            wrapPanel.Children.Add(uc2);
            wrapPanel.Children.Add(uc3);
            wrapPanel.Children.Add(uc4);
            wrapPanel.Children.Add(uc5);
            wrapPanel.Children.Add(uc6);
        }

        private void irCesta1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irAboutUs1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SobreNosotros));
        }

        public void clickUCP()
        {
            this.Frame.Navigate(typeof(PaginaDetalle));
        }

    }
}
