using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TC_Core.Controllers
{
    public class DAOServicio
    {

        static TiendaColchonesDBEntities db = new TiendaColchonesDBEntities();

        // GET: api/Servicios
        static public List<Servicio> GetServicios()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Servicios.ToList();
        }

        static public Servicio GetServicio(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Servicios.Find(id);
        }

        static public int RegistrarServicio(Servicio S)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                //db.Servicios.Add(Servicio);
                db.ppInsertServicio(S.serviceName,S.description,S.servicePrice);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateServicio(Servicio Servicio) //cambiar Precio
        {
            db.Configuration.ProxyCreationEnabled = false;
            var retrievedServicio = db.Servicios.Find(Servicio.id);
            retrievedServicio.servicePrice = Servicio.servicePrice;
            return db.SaveChanges();
        }

        static public int DeleteServicio(int sId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppDeleteServicio(sId);
            return db.SaveChanges();
        }
    }
}