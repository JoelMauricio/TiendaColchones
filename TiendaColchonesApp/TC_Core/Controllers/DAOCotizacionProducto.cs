using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TC_Core.Controllers
{
    public class DAOCotizacionProducto
    {
        static TiendaColchonesDBEntities db = new TiendaColchonesDBEntities();

        // GET: api/Cotizacion_Productos
        static public List<Cotizacion_Producto> GetCotizacion_Productos()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Cotizacion_Producto.ToList();
        }

        static public List<Cotizacion_Producto> GetCotizacion_Productos_PerCotizacion(int noCot)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.ppGetProductsCotizacion(noCot).ToList();
        }

        static public Cotizacion_Producto GetCotizacion_Producto(int noCotizacion, int idProducto)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.ppGetCotizacionProducto(noCotizacion, idProducto).First();
        }

        static public int RegistrarCotizacion_Producto(Cotizacion_Producto C_P)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                //db.Cotizacion_Productos.Add(Cotizacion_Producto);
                db.ppInsertCotizacionProducto(C_P.noCotizacion, C_P.productId, C_P.cantidad);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateCotizacion_Producto(Cotizacion_Producto C_P)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppUpdateCotizacionProducto(C_P.noCotizacion,C_P.productId,C_P.cantidad);
            return db.SaveChanges();
        }

        static public int DeleteCotizacion_Producto(Cotizacion_Producto C_P)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppDeleteCotizacionProducto(C_P.noCotizacion,C_P.productId);
            return db.SaveChanges();
        }
    }
}