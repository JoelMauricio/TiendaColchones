using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TC_Core.Controllers
{
    public class DAOFactura
    {

        static TiendaColchonesDBEntities db = new TiendaColchonesDBEntities();

        // GET: api/Facturas
        static public List<Factura> GetFacturas()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Facturas.ToList();
        }

        static public Factura GetFactura(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Facturas.Find(id);
        }

        static public int RegistrarFactura(Factura F)
        {
            db.Configuration.ProxyCreationEnabled = false;
            try
            {
                //db.Facturas.Add(Factura);
                db.ppInsertFactura(F.noCotizacion,F.cliente,F.tipoComprobante,F.comprobanteFiscal,F.metodoPago);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateFactura(Factura Factura) //Actualizar comprobante fiscal
        {
            db.Configuration.ProxyCreationEnabled = false;
            var retrievedFactura = db.Facturas.Find(Factura.noFactura);
            retrievedFactura.comprobanteFiscal = Factura.comprobanteFiscal;
            return db.SaveChanges();
        }

        static public int DeleteFactura(int FacturaId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.ppDeleteFactura(FacturaId);
            return db.SaveChanges();
        }
    }
}