using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaIntegracion.Controllers
{
    public class CICotizacion
    {

        static CITiendaDBEntities db = new CITiendaDBEntities();

        // GET: api/Cotizacions
        static public List<Cotizacion> GetCotizacions()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Cotizacions.ToList();
        }

        static public Cotizacion GetCotizacion(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Cotizacions.Find(id);
        }

        static public int RegistrarCotizacion(Cotizacion C)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                //db.Cotizacions.Add(Cotizacion);
                db.ppInsertCotizacion(C.cliente,C.subTotal,C.tax,C.total);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateCotizacion(Cotizacion Cotizacion) //Actualizar el Total
        {
            db.Configuration.ProxyCreationEnabled = false;
            //var retrievedCotizacion = db.Cotizacions.Find(Cotizacion.noCotizacion);
            //retrievedCotizacion.total = Cotizacion.total;
            db.ppUpdateCotizacion(Cotizacion.noCotizacion);
            return db.SaveChanges();
        }

        static public int DeleteCotizacion(int cotId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            //db.Cotizacions.Remove(Cotizacion);
            db.ppDeleteCotizacion(cotId);
            return db.SaveChanges();
        }
    }
}