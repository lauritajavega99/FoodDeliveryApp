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
using Navegacion_prueba;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace FoodDeliveryApp
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Menus : Page
    {

        public Menus()
        {
            ProductosApp m1 = new ProductosApp("Menú Bacon", "Bacon Love + patatas clásicas + refresco.", 9.50, false, "ms-appx:///Assets/menuBacon.png");
            UCofertMenus uc_1 =  new UCofertMenus(m1);
            uc_1.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m2 = new ProductosApp("Menú Combo", "Cheese Please + BurguerBros + 2 refrescos + patatas clásicas.", 12.50, false, "ms-appx:///Assets/menu2Hamburguesas.png");
            UCofertMenus uc_2 = new UCofertMenus(m2);
            uc_2.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m3 = new ProductosApp("Menú Imperial", "Imperial + patatas clásicas + ensalada césar + refresco.", 13.00, false, "ms-appx:///Assets/menuBigDobleCarne.png");
            UCofertMenus uc_3 = new UCofertMenus(m3);
            uc_3.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m4 = new ProductosApp("Menú Pizza Lovers", "Pizza Cabramelizada + patatas deluxe + 2 refrescos.", 12.00, false, "ms-appx:///Assets/menuDuoCabramelizada.png");
            UCofertMenus uc_4 = new UCofertMenus(m4);
            uc_4.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m5 = new ProductosApp("Menú Campiña", "Pizza Campiña + fingers de queso + refresco + bola de helado.", 11.50, false, "ms-appx:///Assets/menucampina.png");
            UCofertMenus uc_5 = new UCofertMenus(m5);
            uc_5.Margin = new Thickness(0, 10, 0, 10);

            ProductosApp m6 = new ProductosApp("Menú Crispy", "Chicken Crunchy + fingers de queso + bolas de queso + refresco.", 10.00, false, "ms-appx:///Assets/menuCrispy.png");
            UCofertMenus uc_6 = new UCofertMenus(m6);
            uc_6.Margin = new Thickness(0, 10, 0, 10);


            this.InitializeComponent();
            
            listView.Items.Add(uc_1);
            listView.Items.Add(uc_2);
            listView.Items.Add(uc_3);
            listView.Items.Add(uc_4);
            listView.Items.Add(uc_5);
            listView.Items.Add(uc_6);
        }

        private void irCesta5(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irInicio5(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }
    }
}
