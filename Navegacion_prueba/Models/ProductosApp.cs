using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models
{
   public class ProductosApp
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string imagenProducto { get; set; }
    }

    public class GestionProducto
    {
        public static List<ProductosApp> GetProductos()
        {
            var productosApp = new List<ProductosApp>();

            productosApp.Add(new ProductosApp { Nombre = "Hamburguesa 1", Descripcion = "Con queso", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Hamburguesa 2", Descripcion = "Con queso", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Hamburguesa 3", Descripcion = "Con queso", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Hamburguesa 4", Descripcion = "Con queso", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Hamburguesa 5", Descripcion = "Con queso", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Hamburguesa 6", Descripcion = "Con queso", imagenProducto = "Assets/Hamburguesa1.png" });

            return productosApp;
        }
    }
}
