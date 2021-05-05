using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Producto
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }

    public class ValoresEjemplo
    {
        public static List<Producto> GetValores()
        {
            var productos = new List<Producto>();

            //Una vez añadidos los productos podemos vincular la lista a nuestro gridview como un ItemSource
            productos.Add(new Producto { ID = 1, Nombre = "Hamburguesa", Cantidad = 1, Precio = 4.50 });
            productos.Add(new Producto { ID = 2, Nombre = "Pizza barbacoa", Cantidad = 2, Precio = 8.50 });
            productos.Add(new Producto { ID = 3, Nombre = "Ensalada césar", Cantidad = 1, Precio = 5.00 });
            productos.Add(new Producto { ID = 4, Nombre = "Helado chocolate", Cantidad = 2, Precio = 4.00 });

            return productos;
        }
    }

}
