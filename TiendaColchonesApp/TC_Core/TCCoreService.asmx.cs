using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TC_Core.Controllers;

namespace TC_Core
{
    /// <summary>
    /// Summary description for TCCoreService
    /// </summary>
    [WebService(Namespace = "http://TiendaColchonesCore.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TCCoreService : System.Web.Services.WebService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /*================================== Rol ===================================*/
        [WebMethod]
        public List<Rol> GetRoles()
        {
            log.Info("Se llama el metodo GetRoles() del Core");
            return DAORoles.GetRoles().ToList();
        }

        [WebMethod]
        public Rol GetRol(int id)
        {
            log.Info("Se llama el metodo GetRol() del Core");
            return DAORoles.GetRol(id);
        }

        [WebMethod]
        public int RegistrarRol(Rol rol)
        {
            log.Info("Se llama el metodo RegistrarRoles() del Core");
            return DAORoles.RegistrarRol(rol);
        }

        [WebMethod]
        public int UpdateRoles(Rol rol)
        {
            log.Info("Se llama el metodo UpdateRoles() del Core");
            return DAORoles.UpdateRol(rol);
        }

        [WebMethod]
        public int DeleteRoles(int rolId)
        {
            log.Info("Se llama el metodo DeleteRoles() del Core");
            return DAORoles.DeleteRol(rolId);
        }


        /*================================== Cliente ===================================*/
        [WebMethod]
        public List<Cliente> GetClientes()
        {
            log.Info("Se llama el metodo GetClientes() del Core");
            return DAOCliente.GetClientes().ToList();
        }

        [WebMethod]
        public Cliente GetCliente(int id)
        {
            log.Info("Se llama el metodo GetCliente() del Core");
            return DAOCliente.GetCliente(id);
        }

        [WebMethod]
        public int RegistrarCliente(Cliente cliente)
        {
            log.Info("Se llama el metodo RegistrarClientes() del Core");
            return DAOCliente.RegistrarCliente(cliente);
        }

        [WebMethod]
        public int UpdateClientees(Cliente cliente)
        {
            log.Info("Se llama el metodo UpdateClientees() del Core");
            return DAOCliente.UpdateCliente(cliente);
        }

        [WebMethod]
        public int DeleteClientees(int clienteId)
        {
            log.Info("Se llama el metodo DeleteClientees() del Core");
            return DAOCliente.DeleteCliente(clienteId);
        }


        /*================================== Usuario ===================================*/
        [WebMethod]
        public List<Usuario> GetUsuarios()
        {
            log.Info("Se llama el metodo GetUsuarioes() del Core");
            return DAOUsuario.GetUsuarios().ToList();
        }

        [WebMethod]
        public Usuario GetUsuario(int id)
        {
            log.Info("Se llama el metodo GetUsuario() del Core");
            return DAOUsuario.GetUsuario(id);
        }

        [WebMethod]
        public int RegistrarUsuario(Usuario usuario)
        {
            log.Info("Se llama el metodo RegistrarUsuarios() del Core");
            return DAOUsuario.RegistrarUsuario(usuario);
        }

        [WebMethod]
        public int UpdateUsuarioes(Usuario usuario)
        {
            log.Info("Se llama el metodo UpdateUsuarios() del Core");
            return DAOUsuario.UpdateUsuario(usuario);
        }

        [WebMethod]
        public int DeleteUsuario(int userId)
        {
            log.Info("Se llama el metodo DeleteUsuarios() del Core");
            return DAOUsuario.DeleteUsuario(userId);
        }

        /*================================== Producto ===================================*/
        [WebMethod]
        public List<Producto> GetProductos()
        {
            log.Info("Se llama el metodo GetProductoes() del Core");
            return DAOProduto.GetProductos();
        }

        [WebMethod]
        public Producto GetProducto(int id)
        {
            log.Info("Se llama el metodo GetProducto() del Core");
            return DAOProduto.GetProducto(id);
        }
        
        [WebMethod]
        public int RegistrarProducto(Producto producto)
        {
            log.Info("Se llama el metodo RegistrarProductoes() del Core");
            return DAOProduto.RegistrarProducto(producto);
        }

        [WebMethod]
        public int UpdateProductoes(Producto producto)
        {
            log.Info("Se llama el metodo UpdateProductoes() del Core");
            return DAOProduto.UpdateProducto(producto);
        }

        [WebMethod]
        public int DeleteProductoes(int productoId)
        {
            log.Info("Se llama el metodo DeleteProductoes() del Core");
            return DAOProduto.DeleteProducto(productoId);
        }


        /*================================== Servicio ===================================*/
        [WebMethod]
        public List<Servicio> GetServicios()
        {
            log.Info("Se llama el metodo GetServicioes() del Core");
            return DAOServicio.GetServicios().ToList();
        }

        [WebMethod]
        public Servicio GetServicio(int id)
        {
            log.Info("Se llama el metodo GetServicio() del Core");
            return DAOServicio.GetServicio(id);
        }

        [WebMethod]
        public int RegistrarServicio(Servicio servicio)
        {
            log.Info("Se llama el metodo RegistrarServicioes() del Core");
            return DAOServicio.RegistrarServicio(servicio);
        }

        [WebMethod]
        public int UpdateServicioes(Servicio servicio)
        {
            log.Info("Se llama el metodo UpdateServicioes() del Core");
            return DAOServicio.UpdateServicio(servicio);
        }

        [WebMethod]
        public int DeleteServicioes(int servicioId)
        {
            log.Info("Se llama el metodo DeleteServicioes() del Core");
            return DAOServicio.DeleteServicio(servicioId);
        }


        /*================================== Cotizacion ===================================*/
        [WebMethod]
        public List<Cotizacion> GetCotizaciones()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            return DAOCotizacion.GetCotizacions().ToList();
        }

        [WebMethod]
        public Cotizacion GetCotizacion(int id)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            return DAOCotizacion.GetCotizacion(id);
        }

        [WebMethod]
        public int RegistrarCotizacion(Cotizacion cotizacion)
        {
            log.Info("Se llama el metodo RegistrarCotizaciones() del Core");
            return DAOCotizacion.RegistrarCotizacion(cotizacion);
        }

        [WebMethod]
        public int UpdateCotizaciones(Cotizacion cotizacion)
        {
            log.Info("Se llama el metodo UpdateCotizaciones() del Core");
            return DAOCotizacion.UpdateCotizacion(cotizacion);
        }

        [WebMethod]
        public int DeleteCotizaciones(int cotizacionId)
        {
            log.Info("Se llama el metodo DeleteCotizaciones() del Core");
            return DAOCotizacion.DeleteCotizacion(cotizacionId);
        }

        /*================================== Factura ===================================*/
        [WebMethod]
        public List<Factura> GetFacturaes()
        {
            log.Info("Se llama el metodo GetFacturaes() del Core");
            return DAOFactura.GetFacturas().ToList();
        }

        [WebMethod]
        public Factura GetFactura(int id)
        {
            log.Info("Se llama el metodo GetFactura() del Core");
            return DAOFactura.GetFactura(id);
        }

        [WebMethod]
        public int RegistrarFactura(Factura Factura)
        {
            log.Info("Se llama el metodo RegistrarFacturaes() del Core");
            return DAOFactura.RegistrarFactura(Factura);
        }

        [WebMethod]
        public int UpdateFacturaes(Factura Factura)
        {
            log.Info("Se llama el metodo UpdateFacturaes() del Core");
            return DAOFactura.UpdateFactura(Factura);
        }

        [WebMethod]
        public int DeleteFacturaes(int FacturaId)
        {
            log.Info("Se llama el metodo DeleteFacturaes() del Core");
            return DAOFactura.DeleteFactura(FacturaId);
        }

        /*================================== Cotizacion_Producto ===================================*/
        [WebMethod]
        public List<Cotizacion_Producto> GetCotizacionesProductos()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            return DAOCotizacionProducto.GetCotizacion_Productos().ToList();
        }

        [WebMethod]
        public Cotizacion_Producto GetCotizacionProdcuto(int id)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            return DAOCotizacionProducto.GetCotizacion_Producto(id);
        }

        [WebMethod]
        public int RegistrarCotizacionProducto(Cotizacion_Producto c_p)
        {
            log.Info("Se llama el metodo RegistrarCotizaciones() del Core");
            return DAOCotizacionProducto.RegistrarCotizacion_Producto(c_p);
        }

        [WebMethod]
        public int UpdateCotizacionProducto(Cotizacion_Producto c_p)
        {
            log.Info("Se llama el metodo UpdateCotizaciones() del Core");
            return DAOCotizacionProducto.UpdateCotizacion_Producto(c_p);
        }

        [WebMethod]
        public int DeleteCotizacionProducto(Cotizacion_Producto c_p)
        {
            log.Info("Se llama el metodo DeleteCotizaciones() del Core");
            return DAOCotizacionProducto.DeleteCotizacion_Producto(c_p);
        }

        /*================================== Cuentas_Cobrar ===================================*/
        [WebMethod]
        public List<Cuentas_Cobrar> GetCuentasCobrar()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            return DAOCuentasCobrar.GetCuentas_Cobrars().ToList();
        }

        [WebMethod]
        public Cuentas_Cobrar GetCuentaCobrar(int id)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            return DAOCuentasCobrar.GetCuentas_Cobrar(id);
        }

        [WebMethod]
        public int RegistrarCuentaCobrar(Cuentas_Cobrar cc)
        {
            log.Info("Se llama el metodo RegistrarCotizaciones() del Core");
            return DAOCuentasCobrar.RegistrarCuentas_Cobrar(cc);
        }

        [WebMethod]
        public int UpdateCuentaCobrar(Cuentas_Cobrar cc)
        {
            log.Info("Se llama el metodo UpdateCotizaciones() del Core");
            return DAOCuentasCobrar.UpdateCuentas_Cobrar(cc);
        }

        [WebMethod]
        public int DeleteCuentaCobrar(Cuentas_Cobrar cc)
        {
            log.Info("Se llama el metodo DeleteCotizaciones() del Core");
            return DAOCuentasCobrar.DeleteCuentas_Cobrar(cc);
        }

        /*================================== Cotizacion_Servicio ===================================*/
        readonly Cotizacion_Servicio dummyCS = new Cotizacion_Servicio();

        [WebMethod]
        public List<Cotizacion_Servicio> GetCotizacionesServicios()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            try
            {
                return DAOCotizacionServicio.GetCotizacion_Servicios().ToList();
            }
            catch (Exception)
            {
                List<Cotizacion_Servicio> dummyCSList = new List<Cotizacion_Servicio>();
                return  dummyCSList;
            }
        }

        [WebMethod]
        public Cotizacion_Servicio GetCotizacionServicio(int id)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core"); try
            {
                log.Info("Se intenta traer los datos");
                return DAOCotizacionServicio.GetCotizacion_Servicio(id);
            }
            catch (Exception)
            {
                log.Error("Ha ocurrido un error al traer los datos de cotizacion_servicio");
                return dummyCS;
            }
        }

        [WebMethod]
        public int RegistrarCotizacionServicio(Cotizacion_Servicio c_p)
        {
            log.Info("Se llama el metodo RegistrarCotizaciones() del Core");
            return DAOCotizacionServicio.RegistrarCotizacion_Servicio(c_p);
        }

        [WebMethod]
        public int UpdateCotizacionServicio(Cotizacion_Servicio c_p)
        {
            log.Info("Se llama el metodo UpdateCotizaciones() del Core");
            return DAOCotizacionServicio.UpdateCotizacion_Servicio(c_p);
        }

        [WebMethod]
        public int DeleteCotizacionServicio(Cotizacion_Servicio c_p)
        {
            log.Info("Se llama el metodo DeleteCotizaciones() del Core");
            return DAOCotizacionServicio.DeleteCotizacion_Servicio(c_p);
        }
    }
}
