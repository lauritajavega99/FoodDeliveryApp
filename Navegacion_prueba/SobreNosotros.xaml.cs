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
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace FoodDeliveryApp
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class SobreNosotros : Page
    {
        public SobreNosotros()
        {
            this.InitializeComponent();
            MapControl1.Loaded += MapControl1_Loaded;
        }

        private async void MapControl1_Loaded(object sender, RoutedEventArgs e)
        {

            var center =
                new Geopoint(new BasicGeoposition()
                {
                    Latitude = 38.9861,
                    Longitude = -3.92726

                });

            await MapControl1.TrySetSceneAsync(MapScene.CreateFromLocationAndRadius(center, 3000));
        }

        private void irCesta7(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irInicio7(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }
    }
}

