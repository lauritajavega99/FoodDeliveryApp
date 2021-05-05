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
        public static List<ProductosApp> GetTiposProductos()
        {
            var productosApp = new List<ProductosApp>();

            productosApp.Add(new ProductosApp { Nombre = "Hamburguesas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Pizzas", imagenProducto = "Assets/pizzas.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/entrantes.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/postres.png" });
           

            return productosApp;
        }

        public static List<ProductosApp> GetHamburguesas()
        {
            var productosApp = new List<ProductosApp>();

            productosApp.Add(new ProductosApp { Nombre = "Hamburguesas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Pizzas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/Hamburguesa1.png" });

            return productosApp;
        }

        public static List<ProductosApp> GetPizzas()
        {
            var productosApp = new List<ProductosApp>();

            productosApp.Add(new ProductosApp { Nombre = "Hamburguesas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Pizzas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/Hamburguesa1.png" });

            return productosApp;
        }

        public static List<ProductosApp> GetEntrantes()
        {
            var productosApp = new List<ProductosApp>();

            productosApp.Add(new ProductosApp { Nombre = "Hamburguesas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Pizzas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/Hamburguesa1.png" });

            return productosApp;
        }

        public static List<ProductosApp> GetPostres()
        {
            var productosApp = new List<ProductosApp>();

            productosApp.Add(new ProductosApp { Nombre = "Hamburguesas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Pizzas", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Entrantes", imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProductosApp { Nombre = "Postres", imagenProducto = "Assets/Hamburguesa1.png" });

            return productosApp;
        }
    }
}
