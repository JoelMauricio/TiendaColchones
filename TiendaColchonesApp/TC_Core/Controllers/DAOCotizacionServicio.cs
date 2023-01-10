using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TC_Core.Controllers
{
    public class DAOCotizacionServicio
    {
        static TiendaColchonesDBEntities db = new TiendaColchonesDBEntities();

        // GET: api/Cotizacion_Productos
        static public List<Cotizacion_Servicio> GetCotizacion_Servicios()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Cotizacion_Servicio.ToList();
        }

        static public Cotizacion_Servicio GetCotizacion_Servicio(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Cotizacion_Servicio.Find(id);
        }

        static public int RegistrarCotizacion_Servicio(Cotizacion_Servicio C_S)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                //db.Cotizacion_Productos.Add(Cotizacion_Producto);
                db.ppInsertCotizacionServicio(C_S.noCotizacion, C_S.serviceId, C_S.cantidad);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateCotizacion_Servicio(Cotizacion_Servicio C_S)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppUpdateCotizacionServicio(C_S.noCotizacion, C_S.serviceId, C_S.cantidad);
            return db.SaveChanges();
        }

        static public int DeleteCotizacion_Servicio(Cotizacion_Servicio C_S)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppDeleteCotizacionServicio(C_S.noCotizacion, C_S.serviceId);
            return db.SaveChanges();
        }
    }
}