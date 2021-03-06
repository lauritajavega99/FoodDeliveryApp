using FoodDeliveryApp.Models;
using Microsoft.Toolkit.Uwp.Notifications;
using Navegacion_prueba;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace FoodDeliveryApp
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static List<ProductosApp> cestaCompra = new List<ProductosApp>();
        private static double total;

        public MainPage()
        {
            this.InitializeComponent();
            tilesApp();
        }

        public static List<ProductosApp> Carrito
        {
            get { return cestaCompra; }
            set { cestaCompra = value; }
        }

        public static double Total
        {
            get { return total; }
            set { total = value; }
        }


        public static void clearList()
        {
            cestaCompra.Clear();
        }

        public static void sumaCompra()
        {
            total = 0.0;

            for (int i = 0; i < MainPage.Carrito.Count; i++)
            {
                total += Carrito.ElementAt(i).Precio;
            }

            if (Carrito.Count == 0)
            {
                total = 0.0;
            }

        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                //aquí codigo de la pagina de opciones
                Application.Current.Exit();
            }
            else{

                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag.ToString())
                {
                    case "Inicio":
                        ContentFrame.Navigate(typeof(Inicio));
                        break;
                    case "Productos":
                        ContentFrame.Navigate(typeof(Productos));
                        break;
                    case "Menus":
                        ContentFrame.Navigate(typeof(Menus));
                        break;
                    case "Ofertas":
                        ContentFrame.Navigate(typeof(Ofertas));
                        break;
                    case "Sobre nosotros":
                        ContentFrame.Navigate(typeof(SobreNosotros));
                        break;
                    case "Contacto":
                        ContentFrame.Navigate(typeof(Contacto));
                        break;
                }
            }
        }

        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Inicio));
        }

        private void tilesApp()
        {
            TileContent content = new TileContent()
            {
                Visual = new TileVisual()
                {
                    TileMedium = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            Children =
                    {
                    new AdaptiveText()
                    {
                    Text = "ML'S",
                    HintStyle = AdaptiveTextStyle.Subtitle
                    },

                    new AdaptiveText()
                    {
                    Text = "¡Pincha aquí!",
                    HintStyle = AdaptiveTextStyle.CaptionSubtle
                    },

                            }
                        }
                    },


                    TileWide = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            Children =
                    {
                    new AdaptiveText()
                    {
                    Text = "ML'S Food!",
                    HintStyle = AdaptiveTextStyle.Subtitle
                    },

                    new AdaptiveText()
                    {
                    Text = "Pincha para conocer más.",
                    HintStyle = AdaptiveTextStyle.CaptionSubtle
                    },

                            }
                        }
                    },

                    TileLarge = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            Children =
                    {
                    new AdaptiveText()
                    {
                    Text = "ML'S Food!",
                    HintStyle = AdaptiveTextStyle.Subtitle
                    },

                    new AdaptiveText()
                    {
                    Text = "Pincha para conocer más.",
                    HintStyle = AdaptiveTextStyle.CaptionSubtle
                    },

                            }
                        }
                    },
                }
            };

            var notification = new TileNotification(content.GetXml());
            notification.ExpirationTime = DateTimeOffset.UtcNow.AddSeconds(30);
            var updater = TileUpdateManager.CreateTileUpdaterForApplication();
            updater.Update(notification);
        }

        private void navView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (ContentFrame.CanGoBack)
            {
                ContentFrame.GoBack();
            }
              
           
        }
    }
}
