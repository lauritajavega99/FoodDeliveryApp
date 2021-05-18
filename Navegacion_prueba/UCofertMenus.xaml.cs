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
    public sealed partial class UCofertMenus : UserControl
    {
        public ProductosApp producto;

        public UCofertMenus(ProductosApp pro)
        {
            this.InitializeComponent();
            this.producto = pro;
            this.txtTit.Text = pro.Nombre;
            this.txtDesc.Text = pro.Descripcion;
            this.txtPrec.Text = Convert.ToString(pro.Precio);
            this.imgP.Source = pro.Imagen.Source;
        }

        public String Nombretxt
        {
            get { return txtTit.Text; }
            set { txtTit.Text = value; }
        }

        public String Descriptxt
        {
            get { return txtDesc.Text; }
            set { txtDesc.Text = value; }
        }

        public String Preciotxt
        {
            get { return txtPrec.Text; }
            set { txtPrec.Text = value; }
        }

        public Image ImagenProd
        {
            get { return imgP; }
            set { imgP = value; }
        }
    }
}
