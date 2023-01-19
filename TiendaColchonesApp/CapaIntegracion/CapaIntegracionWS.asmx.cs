using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaIntegracion.Controllers;
using log4net;
using CapaIntegracion.CoreService;

namespace CapaIntegracion
{
    /// <summary>
    /// Summary description for CapaIntegracionWS
    /// </summary>
    [WebService(Namespace = "http://CapaIntegracionWS.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CapaIntegracionWS : System.Web.Services.WebService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        TCCoreServiceSoapClient Core = new TCCoreServiceSoapClient();

        /*================================== Rol ===================================*/
        //readonly Rol dummyR = new Rol();
        //readonly List<Rol> dummyRList = new List<Rol>();

        [WebMethod]
        public List<CoreService.Rol> GetRoles()
        {
            log.Info("Se llama el metodo GetRoles() del Core");
            try
            {
                log.Info("Se intenta traer los registros de los Roles");
                return Core.GetRoles().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los roles");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Rol GetRol(int id)
        {
            log.Info("Se llama el metodo GetRol() del Core");
            try
            {
                log.Info("Se intenta traer el registro especificado");
                return Core.GetRol(id);
            }
            catch (Exception)
            {
                log.Error("Occurrio un error al traer el registro de Rol deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarRol(CoreService.Rol rol)
        {
            log.Info("Se llama el metodo RegistrarRoles() del Core");
            return Core.RegistrarRol(rol);
        }

        [WebMethod]
        public int UpdateRoles(CoreService.Rol rol)
        {
            log.Info("Se llama el metodo UpdateRoles() del Core");
            return Core.UpdateRoles(rol);
        }

        [WebMethod]
        public int DeleteRoles(int rolId)
        {
            log.Info("Se llama el metodo DeleteRoles() del Core");
            return Core.DeleteRoles(rolId);
        }


        /*================================== Cliente ===================================*/
        //readonly Cliente dummyCl = new Cliente();
        //readonly List<Cliente> dummyClList = new List<Cliente>();

        [WebMethod]
        public List<CoreService.Cliente> GetClientes()
        {
            log.Info("Se llama el metodo GetClientes() del Core");
            try
            {
                log.Info("Se intenta traer los registros de los Clientes");
                return Core.GetClientes().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los clientes");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Cliente GetCliente(int id)
        {
            log.Info("Se llama el metodo GetCliente() del Core");
            try
            {
                log.Info("Se intente traer el registro de Cliente");
                return Core.GetCliente(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Cliente deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarCliente(CoreService.Cliente cliente)
        {
            log.Info("Se llama el metodo RegistrarClientes() del Core");
            return Core.RegistrarCliente(cliente);
        }

        [WebMethod]
        public int UpdateClientees(CoreService.Cliente cliente)
        {
            log.Info("Se llama el metodo UpdateClientees() del Core");
            return Core.UpdateClientees(cliente);
        }

        [WebMethod]
        public int DeleteClientees(int clienteId)
        {
            log.Info("Se llama el metodo DeleteClientees() del Core");
            return Core.DeleteClientees(clienteId);
        }


        /*================================== Usuario ===================================*/
        //readonly Usuario dummyU = new Usuario();
        //readonly List<Usuario> dummyUList = new List<Usuario>();

        [WebMethod]
        public List<CoreService.Usuario> GetUsuarios()
        {
            log.Info("Se llama el metodo GetUsuarioes() del Core");
            try
            {
                log.Info("Se intenta trer los registros de los usuarios");
                return Core.GetUsuarios().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los Usuarios");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Usuario GetUsuario(int id)
        {
            log.Info("Se llama el metodo GetUsuario() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Usuario");
                return Core.GetUsuario(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Usuario deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarUsuario(CoreService.Usuario usuario)
        {
            log.Info("Se llama el metodo RegistrarUsuarios() del Core");
            return Core.RegistrarUsuario(usuario);
        }

        [WebMethod]
        public int UpdateUsuarioes(CoreService.Usuario usuario)
        {
            log.Info("Se llama el metodo UpdateUsuarios() del Core");
            return Core.UpdateUsuarioes(usuario);
        }

        [WebMethod]
        public int DeleteUsuario(int userId)
        {
            log.Info("Se llama el metodo DeleteUsuarios() del Core");
            return Core.DeleteUsuario(userId);
        }

        /*================================== Producto ===================================*/
        //readonly Producto dummyP = new Producto();
        //readonly List<Producto> dummyPList = new List<Producto>();

        [WebMethod]
        public List<CoreService.Producto> GetProductos()
        {
            log.Info("Se llama el metodo GetProductoes() del Core");
            try
            {
                log.Info("Se intenta traer los registros de los productos");
                return Core.GetProductos().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los productos");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Producto GetProducto(int id)
        {
            log.Info("Se llama el metodo GetProducto() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Producto deseado");
                return Core.GetProducto(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de producto deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarProducto(CoreService.Producto producto)
        {
            log.Info("Se llama el metodo RegistrarProductoes() del Core");
            return Core.RegistrarProducto(producto);
        }

        [WebMethod]
        public int UpdateProductoes(CoreService.Producto producto)
        {
            log.Info("Se llama el metodo UpdateProductoes() del Core");
            return Core.UpdateProductoes(producto);
        }

        [WebMethod]
        public int DeleteProductoes(int productoId)
        {
            log.Info("Se llama el metodo DeleteProductoes() del Core");
            return Core.DeleteProductoes(productoId);
        }


        /*================================== Servicio ===================================*/
        //readonly Servicio dummyS = new Servicio();
        //readonly List<Servicio> dummySList = new List<Servicio>();

        [WebMethod]
        public List<CoreService.Servicio> GetServicios()
        {
            log.Info("Se llama el metodo GetServicioes() del Core");
            try
            {
                log.Info("Se intenta traer los registros de los Servicios");
                return Core.GetServicios().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los Servicios");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Servicio GetServicio(int id)
        {
            log.Info("Se llama el metodo GetServicio() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Servicio deseado");
                return Core.GetServicio(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Servicio deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarServicio(CoreService.Servicio servicio)
        {
            log.Info("Se llama el metodo RegistrarServicioes() del Core");
            return Core.RegistrarServicio(servicio);
        }

        [WebMethod]
        public int UpdateServicioes(CoreService.Servicio servicio)
        {
            log.Info("Se llama el metodo UpdateServicioes() del Core");
            return Core.UpdateServicioes(servicio);
        }

        [WebMethod]
        public int DeleteServicioes(int servicioId)
        {
            log.Info("Se llama el metodo DeleteServicioes() del Core");
            return Core.DeleteServicioes(servicioId);
        }


        /*================================== Cotizacion ===================================*/
        //readonly Cotizacion dummyC = new Cotizacion();
        //readonly List<Cotizacion> dummyCList = new List<Cotizacion>();

        [WebMethod]
        public List<CoreService.Cotizacion> GetCotizaciones()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            try
            {
                log.Info("Se intenta traer los registros de las cotizaciones");
                return Core.GetCotizaciones().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer lso registros de las cotizaciones");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Cotizacion GetCotizacion(int id)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Cotizacion deseado");
                return Core.GetCotizacion(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Cotizacion deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarCotizacion(CoreService.Cotizacion cotizacion)
        {
            log.Info("Se llama el metodo RegistrarCotizaciones() del Core");
            return Core.RegistrarCotizacion(cotizacion);
        }

        [WebMethod]
        public int UpdateCotizaciones(CoreService.Cotizacion cotizacion)
        {
            log.Info("Se llama el metodo UpdateCotizaciones() del Core");
            return Core.UpdateCotizaciones(cotizacion);
        }

        [WebMethod]
        public int DeleteCotizaciones(int cotizacionId)
        {
            log.Info("Se llama el metodo DeleteCotizaciones() del Core");
            return Core.DeleteCotizaciones(cotizacionId);
        }

        /*================================== Factura ===================================*/
        //readonly Factura dummyF = new Factura();
        //readonly List<Factura> dummyFList = new List<Factura>();

        [WebMethod]
        public List<CoreService.Factura> GetFacturaes()
        {
            log.Info("Se llama el metodo GetFacturaes() del Core");
            try
            {
                log.Info("Se intenta traer los registros de las Facturas");
                return Core.GetFacturaes().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de las Facturas");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Factura GetFactura(int id)
        {
            log.Info("Se llama el metodo GetFactura() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Factura deseado");
                return Core.GetFactura(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Factura deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarFactura(CoreService.Factura Factura)
        {
            log.Info("Se llama el metodo RegistrarFacturaes() del Core");
            return Core.RegistrarFactura(Factura);
        }

        [WebMethod]
        public int UpdateFacturaes(CoreService.Factura Factura)
        {
            log.Info("Se llama el metodo UpdateFacturaes() del Core");
            return Core.UpdateFacturaes(Factura);
        }

        [WebMethod]
        public int DeleteFacturaes(int FacturaId)
        {

            log.Info("Se llama el metodo DeleteFacturaes() del Core");
            return Core.DeleteFacturaes(FacturaId);
        }

        /*================================== Cotizacion_Producto ===================================*/
        //readonly Cotizacion_Producto dummyCP = new Cotizacion_Producto();
        //readonly List<Cotizacion_Producto> dummyCPList = new List<Cotizacion_Producto>();

        [WebMethod]
        public List<CoreService.Cotizacion_Producto> GetCotizacionesProductos()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            try
            {
                log.Info("Se intenta traer los registros de Cotizacion_Producto");
                return Core.GetCotizacionesProductos().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de Cotizacion_Producto");
                return null;
            }
        }


        [WebMethod]
        public List<CoreService.Cotizacion_Producto> GetProductosPorCotizacion(int noCotizacion)
        {
            log.Info("Se llama el metodo GetServiciosPorCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer los registros del metodo GetCotizacion_Servicio_PerCotizacion");
                return Core.GetProductosPorCotizacion(noCotizacion).ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al registros del metodo GetCotizacion_Servicio_PerCotizacion");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Cotizacion_Producto GetCotizacionProdcuto(int noCotizacion, int idProducto)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Cotizacion_Producto deseado");
                return Core.GetCotizacionProdcuto(noCotizacion, idProducto);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Cotizacion_Prodcucto deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarCotizacionProducto(CoreService.Cotizacion_Producto c_p)
        {
            log.Info("Se llama el metodo RegistrarCotizaciones() del Core");
            return Core.RegistrarCotizacionProducto(c_p);
        }

        [WebMethod]
        public int UpdateCotizacionProducto(CoreService.Cotizacion_Producto c_p)
        {
            log.Info("Se llama el metodo UpdateCotizaciones() del Core");
            return Core.UpdateCotizacionProducto(c_p);
        }

        [WebMethod]
        public int DeleteCotizacionProducto(CoreService.Cotizacion_Producto c_p)
        {
            log.Info("Se llama el metodo DeleteCotizaciones() del Core");
            return Core.DeleteCotizacionProducto(c_p);
        }

        /*================================== Cuentas_Cobrar ===================================*/
        //readonly Cuentas_Cobrar dummyCC = new Cuentas_Cobrar();
        //readonly List<Cuentas_Cobrar> dummyCCList = new List<Cuentas_Cobrar>();

        [WebMethod]
        public List<CoreService.Cuentas_Cobrar> GetCuentasCobrar()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            try
            {
                log.Info("Se intenta traer los registros de Cuentas_Cobrar");
                return Core.GetCuentasCobrar().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de Cuentas_Cobrar");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Cuentas_Cobrar GetCuentaCobrar(int noFactura)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Cuentas_Cobrar deseado");
                return Core.GetCuentaCobrar(noFactura);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Cuentas_Cobrar deseado");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarCuentaCobrar(CoreService.Cuentas_Cobrar cc)
        {
            log.Info("Se llama el metodo RegistrarCotizaciones() del Core");
            return Core.RegistrarCuentaCobrar(cc);
        }

        [WebMethod]
        public int UpdateCuentaCobrar(CoreService.Cuentas_Cobrar cc)
        {
            log.Info("Se llama el metodo UpdateCotizaciones() del Core");
            return Core.UpdateCuentaCobrar(cc);
        }

        [WebMethod]
        public int DeleteCuentaCobrar(CoreService.Cuentas_Cobrar cc)
        {
            log.Info("Se llama el metodo DeleteCotizaciones() del Core");
            return Core.DeleteCuentaCobrar(cc);
        }

        /*================================== Cotizacion_Servicio ===================================*/
        //readonly Cotizacion_Servicio dummyCS = new Cotizacion_Servicio();
        //readonly List<Cotizacion_Servicio> dummyCSList = new List<Cotizacion_Servicio>();

        [WebMethod]
        public List<CoreService.Cotizacion_Servicio> GetCotizacionesServicios()
        {
            log.Info("Se llama el metodo GetCotizacionesServicios() del Core");
            try
            {
                log.Info("Se intenta traer los registros del metodo GetCotizacion_Servicio");
                return Core.GetCotizacionesServicios().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros del metodo GetCotizacion_Servicio");
                return null;
            }
        }

        [WebMethod]
        public List<CoreService.Cotizacion_Servicio> GetServiciosPorCotizacion(int noCotizacion)
        {
            log.Info("Se llama el metodo GetServiciosPorCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer los registros del metodo GetCotizacion_Servicio_PerCotizacion");
                return Core.GetServiciosPorCotizacion(noCotizacion).ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al registros del metodo GetCotizacion_Servicio_PerCotizacion");
                return null;
            }
        }

        [WebMethod]
        public CoreService.Cotizacion_Servicio GetCotizacionServicio(int noCotizacion, int idServicio)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer los datos");
                return Core.GetCotizacionServicio(noCotizacion, idServicio);
            }
            catch (Exception)
            {
                log.Error("Ha ocurrido un error al traer los datos de cotizacion_servicio");
                return null;
            }
        }

        [WebMethod]
        public int RegistrarCotizacionServicio(CoreService.Cotizacion_Servicio c_p)
        {
            log.Info("Se llama el metodo RegistrarCotizaciones() del Core");
            return Core.RegistrarCotizacionServicio(c_p);
        }

        [WebMethod]
        public int UpdateCotizacionServicio(CoreService.Cotizacion_Servicio c_p)
        {
            log.Info("Se llama el metodo UpdateCotizaciones() del Core");
            return Core.UpdateCotizacionServicio(c_p);
        }

        [WebMethod]
        public int DeleteCotizacionServicio(CoreService.Cotizacion_Servicio c_p)
        {
            log.Info("Se llama el metodo DeleteCotizaciones() del Core");
            return Core.DeleteCotizacionServicio(c_p);
        }
    }
}
