using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaIntegracion.Controllers
{
    public class CICuentasCobrar
    {
        static CITiendaDBEntities db = new CITiendaDBEntities();

        // GET: api/Cotizacion_Productos
        static public List<Cuentas_Cobrar> GetCuentas_Cobrars()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Cuentas_Cobrar.ToList();
        }

        static public Cuentas_Cobrar GetCuentas_Cobrar(int noFactura)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.ppGetCuentaCobrar(noFactura).First();
        }

        static public int RegistrarCuentas_Cobrar(Cuentas_Cobrar CC)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                //db.Cotizacion_Productos.Add(Cotizacion_Producto);
                db.ppInsertCuentaCobrar(CC.noFactura);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateCuentas_Cobrar(Cuentas_Cobrar CC)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppUpdateCuentaCobrar(CC.noFactura, CC.estadoPago);
            return db.SaveChanges();
        }

        static public int DeleteCuentas_Cobrar(Cuentas_Cobrar CC)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppDeleteCuentaCobrar(CC.noFactura);
            return db.SaveChanges();
        }
    }
}