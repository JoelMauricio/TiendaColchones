using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TC_Core.Controllers
{
    public class DAOCliente
    {

        static TiendaColchonesDBEntities db = new TiendaColchonesDBEntities();

        // GET: api/Clientes
        static public List<Cliente> GetClientes()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Clientes.ToList();
        }

        static public Cliente GetCliente(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Clientes.Find(id);
        }

        static public int RegistrarCliente(Cliente Cliente)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                db.Clientes.Add(Cliente);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateCliente(Cliente Cliente) //cambiar contraseña 
        {
            db.Configuration.ProxyCreationEnabled = false;
            var retrievedCliente = db.Clientes.Find(Cliente.id);
            retrievedCliente.password = Cliente.password;
            return db.SaveChanges();
        }

        static public int DeleteCliente(Cliente Cliente)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.Clientes.Remove(Cliente);
            return db.SaveChanges();
        }
    }
}