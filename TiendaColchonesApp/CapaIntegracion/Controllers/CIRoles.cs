using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaIntegracion.Controllers
{
    public class CIRoles
    {

        static CITiendaDBEntities db = new CITiendaDBEntities();

        // GET: api/Rols
        static public List<Rol> GetRoles()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Rols.ToList();
        }

        static public Rol GetRol(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Rols.Find(id);
        }

        static public int RegistrarRol(Rol Rol)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                //db.Rols.Add(Rol);
                db.ppInsertRol(Rol.rol1);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateRol(Rol Rol)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var retrievedRol = db.Rols.Find(Rol.id);
            retrievedRol.rol1 = Rol.rol1;
            return db.SaveChanges();
        }

        static public int DeleteRol(int rolId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            //db.Rols.Remove(Rol);
            db.ppDeleteRol(rolId);
            return db.SaveChanges();
        }
    }
}