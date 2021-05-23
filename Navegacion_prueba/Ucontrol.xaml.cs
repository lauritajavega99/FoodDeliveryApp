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

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace Navegacion_prueba
{
    public sealed partial class Ucontrol : UserControl
    {


        public Ucontrol()
        {
            this.InitializeComponent();

        }

        public String Nombretxt
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }

        public String Descripciontxt
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }

        public String Preciotxt
        {
            get { return txtPrecio.Text; }
            set { txtPrecio.Text = value; }
        }

        public Image ImagenProd
        {
            get { return imgProd; }
            set { imgProd = value; }
        }
    }
}
