using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TC_Core.Controllers
{
    public class DAOProduto
    {

        static TiendaColchonesDBEntities db = new TiendaColchonesDBEntities();

        // GET: api/Productos
        static public List<Producto> GetProductos()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Productos.ToList();
        }

        static public Producto GetProducto(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Productos.Find(id);
        }

        static public int RegistrarProducto(Producto Producto)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                db.Productos.Add(Producto);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateProducto(Producto Producto) //cambiar precio
        {
            db.Configuration.ProxyCreationEnabled = false;
            var retrievedProducto = db.Productos.Find(Producto.id);
            retrievedProducto.productPrice = Producto.productPrice;
            return db.SaveChanges();
        }

        static public int DeleteProducto(Producto Producto)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.Productos.Remove(Producto);
            return db.SaveChanges();
        }
    }
}