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
        //readonly Rol dummyR = new Rol();
        //readonly List<Rol> dummyRList = new List<Rol>();

        [WebMethod]
        public List<Rol> GetRoles()
        {
            log.Info("Se llama el metodo GetRoles() del Core");
            try
            {
                log.Info("Se intenta traer los registros de los Roles");
                return DAORoles.GetRoles().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los roles");
                return null;
            }
        }

        [WebMethod]
        public Rol GetRol(int id)
        {
            log.Info("Se llama el metodo GetRol() del Core");
            try
            {
                log.Info("Se intenta traer el registro especificado");
                return DAORoles.GetRol(id);
            }
            catch (Exception)
            {
                log.Error("Occurrio un error al traer el registro de Rol deseado");
                return null;
            }
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
        //readonly Cliente dummyCl = new Cliente();
        //readonly List<Cliente> dummyClList = new List<Cliente>();

        [WebMethod]
        public List<Cliente> GetClientes()
        {
            log.Info("Se llama el metodo GetClientes() del Core");
            try
            {
                log.Info("Se intenta traer los registros de los Clientes");
                return DAOCliente.GetClientes().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los clientes");
                return null;
            }
        }

        [WebMethod]
        public Cliente GetCliente(int id)
        {
            log.Info("Se llama el metodo GetCliente() del Core");
            try
            {
                log.Info("Se intente traer el registro de Cliente");
                return DAOCliente.GetCliente(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Cliente deseado");
                return null;
            }
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
        //readonly Usuario dummyU = new Usuario();
        //readonly List<Usuario> dummyUList = new List<Usuario>();

        [WebMethod]
        public List<Usuario> GetUsuarios()
        {
            log.Info("Se llama el metodo GetUsuarioes() del Core");
            try
            {
                log.Info("Se intenta trer los registros de los usuarios");
                return DAOUsuario.GetUsuarios().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los Usuarios");
                return null;
            }
        }

        [WebMethod]
        public Usuario GetUsuario(int id)
        {
            log.Info("Se llama el metodo GetUsuario() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Usuario");
                return DAOUsuario.GetUsuario(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Usuario deseado");
                return null;
            }
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
        //readonly Producto dummyP = new Producto();
        //readonly List<Producto> dummyPList = new List<Producto>();

        [WebMethod]
        public List<Producto> GetProductos()
        {
            log.Info("Se llama el metodo GetProductoes() del Core");
            try
            {
                log.Info("Se intenta traer los registros de los productos");
                return DAOProduto.GetProductos();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los productos");
                return null;
            }
        }

        [WebMethod]
        public Producto GetProducto(int id)
        {
            log.Info("Se llama el metodo GetProducto() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Producto deseado");
                return DAOProduto.GetProducto(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de producto deseado");
                return null;
            }
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
        //readonly Servicio dummyS = new Servicio();
        //readonly List<Servicio> dummySList = new List<Servicio>();

        [WebMethod]
        public List<Servicio> GetServicios()
        {
            log.Info("Se llama el metodo GetServicioes() del Core");
            try
            {
                log.Info("Se intenta traer los registros de los Servicios");
                return DAOServicio.GetServicios().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de los Servicios");
                return null;
            }
        }

        [WebMethod]
        public Servicio GetServicio(int id)
        {
            log.Info("Se llama el metodo GetServicio() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Servicio deseado");
                return DAOServicio.GetServicio(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Servicio deseado");
                return null;
            }
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
        //readonly Cotizacion dummyC = new Cotizacion();
        //readonly List<Cotizacion> dummyCList = new List<Cotizacion>();

        [WebMethod]
        public List<Cotizacion> GetCotizaciones()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            try
            {
                log.Info("Se intenta traer los registros de las cotizaciones");
                return DAOCotizacion.GetCotizacions().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer lso registros de las cotizaciones");
                return null;
            }
        }

        [WebMethod]
        public Cotizacion GetCotizacion(int id)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Cotizacion deseado");
                return DAOCotizacion.GetCotizacion(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Cotizacion deseado");
                return null;
            }
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
        //readonly Factura dummyF = new Factura();
        //readonly List<Factura> dummyFList = new List<Factura>();

        [WebMethod]
        public List<Factura> GetFacturaes()
        {
            log.Info("Se llama el metodo GetFacturaes() del Core");
            try
            {
                log.Info("Se intenta traer los registros de las Facturas");
                return DAOFactura.GetFacturas().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de las Facturas");
                return null;
            }
        }

        [WebMethod]
        public Factura GetFactura(int id)
        {
            log.Info("Se llama el metodo GetFactura() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Factura deseado");
                return DAOFactura.GetFactura(id);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Factura deseado");
                return null;
            }
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
        //readonly Cotizacion_Producto dummyCP = new Cotizacion_Producto();
        //readonly List<Cotizacion_Producto> dummyCPList = new List<Cotizacion_Producto>();

        [WebMethod]
        public List<Cotizacion_Producto> GetCotizacionesProductos()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            try
            {
                log.Info("Se intenta traer los registros de Cotizacion_Producto");
                return DAOCotizacionProducto.GetCotizacion_Productos().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de Cotizacion_Producto");
                return null;
            }
        }


        [WebMethod]
        public List<Cotizacion_Producto> GetProductosPorCotizacion(int noCotizacion)
        {
            log.Info("Se llama el metodo GetServiciosPorCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer los registros del metodo GetCotizacion_Servicio_PerCotizacion");
                return DAOCotizacionProducto.GetCotizacion_Productos_PerCotizacion(noCotizacion);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al registros del metodo GetCotizacion_Servicio_PerCotizacion");
                return null;
            }
        }

        [WebMethod]
        public Cotizacion_Producto GetCotizacionProdcuto(int noCotizacion, int idProducto)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Cotizacion_Producto deseado");
                return DAOCotizacionProducto.GetCotizacion_Producto(noCotizacion,idProducto);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Cotizacion_Prodcucto deseado");
                return null;
            }
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
        //readonly Cuentas_Cobrar dummyCC = new Cuentas_Cobrar();
        //readonly List<Cuentas_Cobrar> dummyCCList = new List<Cuentas_Cobrar>();

        [WebMethod]
        public List<Cuentas_Cobrar> GetCuentasCobrar()
        {
            log.Info("Se llama el metodo GetCotizaciones() del Core");
            try
            {
                log.Info("Se intenta traer los registros de Cuentas_Cobrar");
                return DAOCuentasCobrar.GetCuentas_Cobrars().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros de Cuentas_Cobrar");
                return null;
            }
        }

        [WebMethod]
        public Cuentas_Cobrar GetCuentaCobrar(int noFactura)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer el registro de Cuentas_Cobrar deseado");
                return DAOCuentasCobrar.GetCuentas_Cobrar(noFactura);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer el registro de Cuentas_Cobrar deseado");
                return null;
            }
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
        //readonly Cotizacion_Servicio dummyCS = new Cotizacion_Servicio();
        //readonly List<Cotizacion_Servicio> dummyCSList = new List<Cotizacion_Servicio>();

        [WebMethod]
        public List<Cotizacion_Servicio> GetCotizacionesServicios()
        {
            log.Info("Se llama el metodo GetCotizacionesServicios() del Core");
            try
            {
                log.Info("Se intenta traer los registros del metodo GetCotizacion_Servicio");
                return DAOCotizacionServicio.GetCotizacion_Servicios().ToList();
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al traer los registros del metodo GetCotizacion_Servicio");
                return  null;
            }
        }

        [WebMethod]
        public List<Cotizacion_Servicio> GetServiciosPorCotizacion(int noCotizacion)
        {
            log.Info("Se llama el metodo GetServiciosPorCotizacion() del Core");
            try
            {
                log.Info("Se intenta traer los registros del metodo GetCotizacion_Servicio_PerCotizacion");
                return DAOCotizacionServicio.GetCotizacion_Servicios_PerCotizacion(noCotizacion);
            }
            catch (Exception)
            {
                log.Error("Ocurrio un error al registros del metodo GetCotizacion_Servicio_PerCotizacion");
                return null;
            }
        }

        [WebMethod]
        public Cotizacion_Servicio GetCotizacionServicio(int noCotizacion, int idServicio)
        {
            log.Info("Se llama el metodo GetCotizacion() del Core"); 
            try
            {
                log.Info("Se intenta traer los datos");
                return DAOCotizacionServicio.GetCotizacion_Servicio(noCotizacion,idServicio);
            }
            catch (Exception)
            {
                log.Error("Ha ocurrido un error al traer los datos de cotizacion_servicio");
                return null;
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
