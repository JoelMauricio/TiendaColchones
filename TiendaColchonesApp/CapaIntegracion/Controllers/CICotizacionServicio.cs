using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaIntegracion.Controllers
{
    public class CICotizacionServicio
    {

        static CITiendaDBEntities db = new CITiendaDBEntities();

        // GET: api/Cotizacion_Productos
        static public List<Cotizacion_Servicio> GetCotizacion_Servicios()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Cotizacion_Servicio.ToList();
        }

        static public List<Cotizacion_Servicio> GetCotizacion_Servicios_PerCotizacion(int noCot)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.ppGetServicioCotizacion(noCot).ToList();
        }

        static public Cotizacion_Servicio GetCotizacion_Servicio(int noCot, int idSer)
        {
            
            db.Configuration.ProxyCreationEnabled = false;
            return db.ppGetCotizacionServicio(noCot,idSer).First();
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