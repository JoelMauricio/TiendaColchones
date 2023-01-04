using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TC_Core.Controllers
{
    public class DAOUsuario
    {

        static TiendaColchonesDBEntities db = new TiendaColchonesDBEntities();

        // GET: api/Usuarios
        static public List<Usuario> GetUsuarios()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Usuarios.ToList();
        }

        static public Usuario GetUsuario(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Usuarios.Find(id);
        }

        static public int RegistrarUsuario(Usuario Usuario)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                db.Usuarios.Add(Usuario);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateUsuario(Usuario Usuario) //cambiar contraseña 
        {
            db.Configuration.ProxyCreationEnabled = false;
            var retrievedUsuario = db.Usuarios.Find(Usuario.id);
            retrievedUsuario.password = Usuario.password;
            return db.SaveChanges();
        }

        static public int DeleteUsuario(Usuario Usuario)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.Usuarios.Remove(Usuario);
            return db.SaveChanges();
        }
    }
}