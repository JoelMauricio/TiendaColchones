using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaIntegracion.Controllers
{
    public class CIUsuario
    {

        static CITiendaDBEntities db = new CITiendaDBEntities();

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

        static public int RegistrarUsuario(Usuario Us)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                //db.Usuarios.Add(Usuario);
                db.ppInsertUsuario(Us.username,Us.password,Us.cedula,Us.nombre,Us.apellido,Us.sexo,Us.telefono,Us.correo);
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

        static public int DeleteUsuario(int UserId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppDeleteUsuario(UserId);
            return db.SaveChanges();
        }
    }
}