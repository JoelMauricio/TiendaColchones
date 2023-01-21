using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbardorCore
{
    internal class Program
    {
        private static string mensajeError = "No hay resultado disponibles, asegure haber ingresado los datos correctos";
        private static string mensajeError2 = "Ha ocurrido un error, asegure que los datos ingresados son correctos.";
        static void Main(string[] args)
        {
            CoreService.TCCoreServiceSoapClient Core = new CoreService.TCCoreServiceSoapClient();
            bool AccesoHabilitado = false;
            bool condicion = true;

            while (condicion)
            {
                if (!AccesoHabilitado)
                {
                    CoreService.Usuario usuario = new CoreService.Usuario();
                    Console.WriteLine("Bienvenido al Core de Tienda");
                    Console.WriteLine("Por favor, Ingrese sus credenciales para poder entrar");
                    Console.Write("\nNombre de Usuario: ");
                    usuario.username = Console.ReadLine();
                    Console.Write("\nConstraseña: ");
                    usuario.password = Console.ReadLine();

                    try
                    {
                        if ((usuario.username == ConfigurationManager.AppSettings.Get("defaultCoreUser") && usuario.password == ConfigurationManager.AppSettings.Get("defaultCorePassword"))
                        || (ValidarUsuario(usuario) && ValidarContraseña(usuario)))
                        {
                            AccesoHabilitado = true;
                        }
                        else AccesoHabilitado = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No se puede conectar con el Core");
                        Console.ReadKey();
                    }
                }

                if (AccesoHabilitado)
                {
                    Console.Clear();
                    string Seleccion;
                    Console.WriteLine("Favor ingrese el número de la entidad que desea probar, u otro para salir");
                    Console.WriteLine("1. Rol");
                    Console.WriteLine("2. Usuario");
                    Console.WriteLine("3. Cliente");
                    Console.WriteLine("4. Producto");
                    Console.WriteLine("5. Servicio");
                    Console.WriteLine("6. Cotización");
                    Console.WriteLine("7. Cotizacion_Producto");
                    Console.WriteLine("8. Cotizacion_Servicio");
                    Console.WriteLine("9. Factura");
                    Console.WriteLine("10. Cuentas_Cobrar");
                    Console.WriteLine("11. Cerrar Sesion");
                    Console.WriteLine("12. Cerrar Aplicación");
                    Seleccion = Console.ReadLine();
                    string OPCION = "";
                    string entity = "";
                    Console.Clear();
                    switch (Seleccion)
                    {
                        case "1":
                            entity = "Rol";
                            SeleccionOpcion(entity);
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    try
                                    {
                                        CoreService.Rol rol = new CoreService.Rol();
                                        Console.WriteLine("Nombre del rol:");
                                        rol.rol1 = Console.ReadLine();
                                        Core.RegistrarRol(rol);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id del Rol que desea buscar");
                                        int rolId = Int32.Parse(Console.ReadLine());
                                        CoreService.Rol resultadoRol = Core.GetRol(rolId);
                                        if (resultadoRol != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + resultadoRol.id);
                                            Console.WriteLine("Nombre del Rol: " + resultadoRol.rol1);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Rol que desea modificar");
                                        int UpdateRol = Int32.Parse(Console.ReadLine());
                                        CoreService.Rol rolUpdate = new CoreService.Rol();
                                        rolUpdate.id = UpdateRol;
                                        Console.WriteLine("Ingrese el nuevo nombre del rol");
                                        rolUpdate.rol1 = Console.ReadLine();
                                        Core.UpdateRoles(rolUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Rol que desea Borrar");
                                        int delRol = Int32.Parse(Console.ReadLine());
                                        CoreService.Rol rolDelete = new CoreService.Rol();
                                        rolDelete.id = delRol;
                                        Core.DeleteRoles(rolDelete.id);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Rol> lista = Core.GetRoles().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Rol item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + item.id);
                                            Console.WriteLine("Nombre del Rol: " + item.rol1);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "2":
                            entity = "Usuario";
                            SeleccionOpcion(entity);
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    try
                                    {
                                        CoreService.Usuario u = new CoreService.Usuario();
                                        Console.WriteLine("Nombre del Usuario:");
                                        u.nombre = Console.ReadLine();
                                        Console.WriteLine("Apellido del Usuario:");
                                        u.apellido = Console.ReadLine();
                                        Console.WriteLine("Username del Usuario:");
                                        u.username = Console.ReadLine();
                                        Console.WriteLine("Contraseña del Usuario:");
                                        u.password = Console.ReadLine();
                                        Console.WriteLine("Sexo del Usuario: (S/M)");
                                        u.sexo = Console.ReadLine();
                                        u.cedula = "100000000";
                                        u.telefono = "8090009999";
                                        u.correo = "c" + u.nombre + "@email.com";
                                        Core.RegistrarUsuario(u);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id del Usuario que desea buscar");
                                        int userId = Int32.Parse(Console.ReadLine());
                                        CoreService.Usuario resultadoUser = Core.GetUsuario(userId);
                                        if (resultadoUser != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + resultadoUser.id);
                                            Console.WriteLine("Nombre del Usuario: " + resultadoUser.nombre);
                                            Console.WriteLine("Apellido del Usuario: " + resultadoUser.apellido);
                                            Console.WriteLine("Username del Usuario: " + resultadoUser.username);
                                            Console.WriteLine("Password del Usuario: " + resultadoUser.password);
                                            Console.WriteLine("Cedula del Usuario: " + resultadoUser.cedula);
                                            Console.WriteLine("Sexo del Usuario: " + resultadoUser.sexo);
                                            Console.WriteLine("Telefono del Usuario: " + resultadoUser.telefono);
                                            Console.WriteLine("Correo del Usuario: " + resultadoUser.correo);
                                            Console.WriteLine("Rol del Usuario: " + resultadoUser.rol);
                                            Console.WriteLine("status del Usuario: " + resultadoUser.state);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Usuario que desea modificar");
                                        int UpdateUser = Int32.Parse(Console.ReadLine());
                                        CoreService.Usuario UserUpdate = new CoreService.Usuario();
                                        UserUpdate.id = UpdateUser;
                                        Console.WriteLine("Ingrese el nuevo nombre del rol");
                                        UserUpdate.password = Console.ReadLine();
                                        Core.UpdateUsuarioes(UserUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Usuario que desea Borrar");
                                        int delUser = Int32.Parse(Console.ReadLine());
                                        CoreService.Usuario UserDelete = new CoreService.Usuario();
                                        UserDelete.id = delUser;
                                        Core.DeleteUsuario(delUser);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Usuario> lista = Core.GetUsuarios().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Usuario item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + item.id);
                                            Console.WriteLine("Nombre del Usuario: " + item.nombre);
                                            Console.WriteLine("Apellido del Usuario: " + item.apellido);
                                            Console.WriteLine("Username del Usuario: " + item.username);
                                            Console.WriteLine("Password del Usuario: " + item.password);
                                            Console.WriteLine("Cedula del Usuario: " + item.cedula);
                                            Console.WriteLine("Sexo del Usuario: " + item.sexo);
                                            Console.WriteLine("Telefono del Usuario: " + item.telefono);
                                            Console.WriteLine("Correo del Usuario: " + item.correo);
                                            Console.WriteLine("Rol del Usuario: " + item.rol);
                                            Console.WriteLine("status del Usuario: " + item.state);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "3":
                            entity = "Cliente";
                            SeleccionOpcion(entity);
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    CoreService.Cliente c = new CoreService.Cliente();
                                    try
                                    {
                                        Console.WriteLine("Nombre del Cliente:");
                                        c.nombre = Console.ReadLine();
                                        Console.WriteLine("Apellido del Cliente:");
                                        c.apellido = Console.ReadLine();
                                        Console.WriteLine("Username del Cliente:");
                                        c.username = Console.ReadLine();
                                        Console.WriteLine("Contraseña del Cliente:");
                                        c.password = Console.ReadLine();
                                        Console.WriteLine("Sexo del Cliente: (S/M)");
                                        c.sexo = Console.ReadLine();
                                        c.cedula = "100000000";
                                        c.telefono = "8090009999";
                                        c.correo = "c" + c.nombre + "@email.com";
                                        Core.RegistrarCliente(c);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id del Cliente que desea buscar");
                                        int userId = Int32.Parse(Console.ReadLine());
                                        CoreService.Cliente resultadoUser = Core.GetCliente(userId);
                                        if (resultadoUser != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + resultadoUser.id);
                                            Console.WriteLine("Nombre del Cliente: " + resultadoUser.nombre);
                                            Console.WriteLine("Apellido del Cliente: " + resultadoUser.apellido);
                                            Console.WriteLine("Username del Cliente: " + resultadoUser.username);
                                            Console.WriteLine("Password del Cliente: " + resultadoUser.password);
                                            Console.WriteLine("Cedula del Cliente: " + resultadoUser.cedula);
                                            Console.WriteLine("Sexo del Cliente: " + resultadoUser.sexo);
                                            Console.WriteLine("Telefono del Cliente: " + resultadoUser.telefono);
                                            Console.WriteLine("Correo del Cliente: " + resultadoUser.correo);
                                            Console.WriteLine("status del Cliente: " + resultadoUser.state);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Cliente que desea modificar");
                                        int UpdateUser = Int32.Parse(Console.ReadLine());
                                        CoreService.Cliente UserUpdate = new CoreService.Cliente();
                                        UserUpdate.id = UpdateUser;
                                        Console.WriteLine("Ingrese el nuevo nombre del rol");
                                        UserUpdate.password = Console.ReadLine();
                                        Core.UpdateClientees(UserUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Cliente que desea Borrar");
                                        int delCliente = Int32.Parse(Console.ReadLine());
                                        CoreService.Cliente ClienteDelete = new CoreService.Cliente();
                                        ClienteDelete.id = delCliente;
                                        Core.DeleteClientees(ClienteDelete.id);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Cliente> lista = Core.GetClientes().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Cliente item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + item.id);
                                            Console.WriteLine("Nombre del Cliente: " + item.nombre);
                                            Console.WriteLine("Apellido del Cliente: " + item.apellido);
                                            Console.WriteLine("Username del Cliente: " + item.username);
                                            Console.WriteLine("Password del Cliente: " + item.password);
                                            Console.WriteLine("Cedula del Cliente: " + item.cedula);
                                            Console.WriteLine("Sexo del Cliente: " + item.sexo);
                                            Console.WriteLine("Telefono del Cliente: " + item.telefono);
                                            Console.WriteLine("Correo del Cliente: " + item.correo);
                                            Console.WriteLine("status del Cliente: " + item.state);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "4":
                            entity = "Producto";
                            SeleccionOpcion(entity);
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    CoreService.Producto p = new CoreService.Producto();
                                    try
                                    {
                                        Console.WriteLine("Nombre del Producto:");
                                        p.productName = Console.ReadLine();
                                        Console.WriteLine("Size del Producto:");
                                        p.size = Console.ReadLine();
                                        Console.WriteLine("Descripción del Producto:");
                                        p.description = Console.ReadLine();
                                        Console.WriteLine("Precio del Producto:");
                                        p.productPrice = Decimal.Parse(Console.ReadLine());
                                        Console.WriteLine("Cantidad en Stock: ");
                                        p.stock = Int32.Parse(Console.ReadLine());
                                        Core.RegistrarProducto(p);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id del Producto que desea buscar");
                                        int pId = Int32.Parse(Console.ReadLine());
                                        CoreService.Producto resultadoP = Core.GetProducto(pId);
                                        if (resultadoP != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + resultadoP.id);
                                            Console.WriteLine("Nombre del Producto: " + resultadoP.productName);
                                            Console.WriteLine("size del Producto: " + resultadoP.size);
                                            Console.WriteLine("descripción del Producto: " + resultadoP.description);
                                            Console.WriteLine("Price del Producto: " + resultadoP.productPrice);
                                            Console.WriteLine("Stock del Producto: " + resultadoP.stock);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Producto que desea modificar");
                                        int UpdateProduct = Int32.Parse(Console.ReadLine());
                                        CoreService.Producto ProductoUpdate = new CoreService.Producto();
                                        ProductoUpdate.id = UpdateProduct;
                                        Console.WriteLine("Ingrese el nuevo precio del producto");
                                        ProductoUpdate.productPrice = Decimal.Parse(Console.ReadLine());
                                        Core.UpdateProductoes(ProductoUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Producto que desea Borrar");
                                        int delProducto = Int32.Parse(Console.ReadLine());
                                        CoreService.Producto ProductoDelete = new CoreService.Producto();
                                        ProductoDelete.id = delProducto;
                                        Core.DeleteProductoes(ProductoDelete.id);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Producto> lista = Core.GetProductos().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Producto item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + item.id);
                                            Console.WriteLine("Nombre del Producto: " + item.productName);
                                            Console.WriteLine("size del Producto: " + item.size);
                                            Console.WriteLine("descripción del Producto: " + item.description);
                                            Console.WriteLine("Price del Producto: " + item.productPrice);
                                            Console.WriteLine("Stock del Producto: " + item.stock);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "5":
                            entity = "Servicio";
                            SeleccionOpcion(entity);
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    try
                                    {
                                        CoreService.Servicio s = new CoreService.Servicio();
                                        Console.WriteLine("Nombre del Servicio:");
                                        s.serviceName = Console.ReadLine();
                                        Console.WriteLine("Descripción del Servicio:");
                                        s.description = Console.ReadLine();
                                        Console.WriteLine("Precio del Servicio:");
                                        s.servicePrice = Decimal.Parse(Console.ReadLine());
                                        Core.RegistrarServicio(s);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id del Servicio que desea buscar");
                                        int sId = Int32.Parse(Console.ReadLine());
                                        CoreService.Servicio resultadoS = Core.GetServicio(sId);
                                        if (resultadoS != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + resultadoS.id);
                                            Console.WriteLine("Nombre del Servicio: " + resultadoS.serviceName);
                                            Console.WriteLine("descripción del Servicio: " + resultadoS.description);
                                            Console.WriteLine("Precio del Servicio: " + resultadoS.servicePrice);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Servicio que desea modificar");
                                        int UpdateServicio = Int32.Parse(Console.ReadLine());
                                        CoreService.Servicio ServicioUpdate = new CoreService.Servicio();
                                        ServicioUpdate.id = UpdateServicio;
                                        Console.WriteLine("Ingrese el nuevo precio del Servicio");
                                        ServicioUpdate.servicePrice = Decimal.Parse(Console.ReadLine());
                                        Core.UpdateServicioes(ServicioUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Servicio que desea Borrar");
                                        int delServicio = Int32.Parse(Console.ReadLine());
                                        CoreService.Servicio ServicioDelete = new CoreService.Servicio();
                                        ServicioDelete.id = delServicio;
                                        Core.DeleteServicioes(ServicioDelete.id);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Servicio> lista = Core.GetServicios().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Servicio item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id: \t" + item.id);
                                            Console.WriteLine("Nombre del Servicio: " + item.serviceName);
                                            Console.WriteLine("descripción del Servicio: " + item.description);
                                            Console.WriteLine("Price del Servicio: " + item.servicePrice);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "6":
                            entity = "Cotización";
                            SeleccionOpcion(entity);
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    CoreService.Cotizacion c = new CoreService.Cotizacion();
                                    try
                                    {
                                        Console.WriteLine("Id del clinete de la Cotizacion:");
                                        c.cliente = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Subtotal de la Cotizacion:");
                                        c.subTotal = Decimal.Parse(Console.ReadLine());
                                        Console.WriteLine("Impuesto del Cotizacion:");
                                        c.tax = Decimal.Parse(Console.ReadLine());
                                        Console.WriteLine("Mont del Cotizacion:");
                                        c.total = Decimal.Parse(Console.ReadLine());
                                        Core.RegistrarCotizacion(c);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id del Cotizacion que desea buscar");
                                        int cId = Int32.Parse(Console.ReadLine());
                                        CoreService.Cotizacion resultadoC = Core.GetCotizacion(cId);
                                        if (resultadoC != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("No. Cotizacion: \t" + resultadoC.noCotizacion);
                                            Console.WriteLine("Id del cliente de la Cotizacion: " + resultadoC.cliente);
                                            Console.WriteLine("Subtotal de la Cotizacion: " + resultadoC.subTotal);
                                            Console.WriteLine("Impuesto de la Cotizacion: " + resultadoC.tax);
                                            Console.WriteLine("Monto total de la Cotizacion: " + resultadoC.total);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    CoreService.Cotizacion CotizacionUpdate = new CoreService.Cotizacion();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Cotizacion que desea Actualizar");
                                        int UpdateCotizacion = Int32.Parse(Console.ReadLine());
                                        CotizacionUpdate.noCotizacion = UpdateCotizacion;
                                        Core.UpdateCotizaciones(CotizacionUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    CoreService.Cotizacion CotizacionDelete = new CoreService.Cotizacion();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Cotizacion que desea Borrar");
                                        int delCotizacion = Int32.Parse(Console.ReadLine());
                                        CotizacionDelete.noCotizacion = delCotizacion;
                                        Core.DeleteCotizaciones(CotizacionDelete.noCotizacion);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Cotizacion> lista = Core.GetCotizaciones().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Cotizacion item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("No.Cotizacion: \t" + item.noCotizacion);
                                            Console.WriteLine("Id del cliente de la Cotizacion: " + item.cliente);
                                            Console.WriteLine("Subtotal de la Cotizacion: " + item.subTotal);
                                            Console.WriteLine("Impuesto de la Cotizacion: " + item.tax);
                                            Console.WriteLine("Monto total de la Cotizacion: " + item.total);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "7":
                            entity = "Cotización_Producto";
                            SeleccionOpcion(entity);
                            Console.WriteLine("6. Traer los Productos de una Cotizacion");
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    CoreService.Cotizacion_Producto c = new CoreService.Cotizacion_Producto();
                                    try
                                    {
                                        Console.WriteLine("No. de la Cotizacion:");
                                        c.noCotizacion = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Id del Producto:");
                                        c.productId = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Cantidad:");
                                        c.cantidad = Int32.Parse(Console.ReadLine());
                                        Core.RegistrarCotizacionProducto(c);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id del Cotizacion que desea buscar");
                                        int cId = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte el Id del Producto que desea buscar");
                                        int pId = Int32.Parse(Console.ReadLine());
                                        CoreService.Cotizacion_Producto resultadoC = Core.GetCotizacionProdcuto(cId, pId);
                                        if (resultadoC != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id de la cotizacion: " + resultadoC.noCotizacion);
                                            Console.WriteLine("Id del producto: " + resultadoC.productId);
                                            Console.WriteLine("Cantidad: " + resultadoC.cantidad);
                                            Console.WriteLine("Subtotal: " + resultadoC.subTotal);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    CoreService.Cotizacion_Producto Cotizacion_ProductoUpdate = new CoreService.Cotizacion_Producto();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id de la Cotizacion que desea Actualizar");
                                        Cotizacion_ProductoUpdate.noCotizacion = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese el Id del Producto que desea Actualizar");
                                        Cotizacion_ProductoUpdate.productId = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese la nueva cantidad");
                                        Cotizacion_ProductoUpdate.cantidad = Int32.Parse(Console.ReadLine());
                                        Core.UpdateCotizacionProducto(Cotizacion_ProductoUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    CoreService.Cotizacion_Producto Cotizacion_ProductoDelete = new CoreService.Cotizacion_Producto();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id de la Cotizacion que desea Borrar");
                                        Cotizacion_ProductoDelete.noCotizacion = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese el Id del Producto que desea Borrar");
                                        Cotizacion_ProductoDelete.productId = Int32.Parse(Console.ReadLine());
                                        Core.DeleteCotizacionProducto(Cotizacion_ProductoDelete);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Cotizacion_Producto> lista = Core.GetCotizacionesProductos().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Cotizacion_Producto item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id de la cotizacion: " + item.noCotizacion);
                                            Console.WriteLine("Id del producto: " + item.productId);
                                            Console.WriteLine("Cantidad: " + item.cantidad);
                                            Console.WriteLine("Subtotal: " + item.subTotal);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id de la Cotizacion: ");
                                        int noCot = Int32.Parse(Console.ReadLine());
                                        List<CoreService.Cotizacion_Producto> listC = Core.GetProductosPorCotizacion(noCot).ToList();
                                        if (listC.Any())
                                        {
                                            foreach (CoreService.Cotizacion_Producto item in listC)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Id de la cotizacion: " + item.noCotizacion);
                                                Console.WriteLine("Id del producto: " + item.productId);
                                                Console.WriteLine("Cantidad: " + item.cantidad);
                                                Console.WriteLine("Subtotal: " + item.subTotal);
                                            }
                                        }
                                        else if (!listC.Any())
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "8":
                            entity = "Cotización_Servicio";
                            SeleccionOpcion(entity);
                            Console.WriteLine("6. Traer los Servicios de una Cotizacion");
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    CoreService.Cotizacion_Servicio cs = new CoreService.Cotizacion_Servicio();
                                    try
                                    {
                                        Console.WriteLine("No. de la Cotizacion:");
                                        cs.noCotizacion = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Id del Servicio:");
                                        cs.serviceId = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Cantidad:");
                                        cs.cantidad = Int32.Parse(Console.ReadLine());
                                        Core.RegistrarCotizacionServicio(cs);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id de la Cotizacion que desea buscar");
                                        int csId = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Inserte el Id del Servicio que desea buscar");
                                        int sId = Int32.Parse(Console.ReadLine());
                                        CoreService.Cotizacion_Servicio resultadoCS = Core.GetCotizacionServicio(csId, sId);
                                        if (resultadoCS != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id de la cotizacion: " + resultadoCS.noCotizacion);
                                            Console.WriteLine("Id del servicio: " + resultadoCS.serviceId);
                                            Console.WriteLine("Cantidad: " + resultadoCS.cantidad);
                                            Console.WriteLine("Subtotal: " + resultadoCS.subTotal);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    try
                                    {
                                        CoreService.Cotizacion_Servicio Cotizacion_ServicioUpdate = new CoreService.Cotizacion_Servicio();
                                        Console.WriteLine("Ingrese el Id de la Cotizacion que desea Actualizar");
                                        Cotizacion_ServicioUpdate.noCotizacion = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese el Id del Servicio que desea Actualizar");
                                        Cotizacion_ServicioUpdate.serviceId = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese la nueva cantidad");
                                        Cotizacion_ServicioUpdate.cantidad = Int32.Parse(Console.ReadLine());
                                        Core.UpdateCotizacionServicio(Cotizacion_ServicioUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    try
                                    {
                                        CoreService.Cotizacion_Servicio Cotizacion_ServicioDelete = new CoreService.Cotizacion_Servicio();
                                        Console.WriteLine("Ingrese el Id de la Cotizacion que desea Borrar");
                                        Cotizacion_ServicioDelete.noCotizacion = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese el Id del Servicio que desea Borrar");
                                        Cotizacion_ServicioDelete.serviceId = Int32.Parse(Console.ReadLine());
                                        Core.DeleteCotizacionServicio(Cotizacion_ServicioDelete);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Cotizacion_Servicio> lista = Core.GetCotizacionesServicios().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Cotizacion_Servicio item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Id de la cotizacion: " + item.noCotizacion);
                                            Console.WriteLine("Id del producto: " + item.serviceId);
                                            Console.WriteLine("Cantidad: " + item.cantidad);
                                            Console.WriteLine("Subtotal: " + item.subTotal);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "6":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id de la Cotizacion: ");
                                        int noCot = Int32.Parse(Console.ReadLine());
                                        List<CoreService.Cotizacion_Servicio> listC = Core.GetServiciosPorCotizacion(noCot).ToList();
                                        if (listC.Any())
                                        {
                                            foreach (CoreService.Cotizacion_Servicio item in listC)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Id de la cotizacion: " + item.noCotizacion);
                                                Console.WriteLine("Id del producto: " + item.serviceId);
                                                Console.WriteLine("Cantidad: " + item.cantidad);
                                                Console.WriteLine("Subtotal: " + item.subTotal);
                                            }
                                        }
                                        else if (!listC.Any())
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                        Console.ReadKey();
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "9":
                            entity = "Factura";
                            SeleccionOpcion(entity);
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    CoreService.Factura f = new CoreService.Factura();
                                    try
                                    {
                                        Console.WriteLine("No. de la Cotizacion:");
                                        f.noCotizacion = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Id del cliente:");
                                        f.cliente = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Tipo de comprobante:");
                                        f.tipoComprobante = Console.ReadLine();
                                        Console.WriteLine("Comprobante:");
                                        f.comprobanteFiscal = Console.ReadLine();
                                        Console.WriteLine("Metodo de Pago:");
                                        f.metodoPago = Console.ReadLine();
                                        Core.RegistrarFactura(f);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el Id del Facturaque desea buscar");
                                        int cId = Int32.Parse(Console.ReadLine());
                                        CoreService.Factura resultadoF = Core.GetFactura(cId);
                                        if (resultadoF != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("No. Factura: \t" + resultadoF.noFactura);
                                            Console.WriteLine("Id de la cotizacion: " + resultadoF.noCotizacion);
                                            Console.WriteLine("Id del cliente de la factura: " + resultadoF.cliente);
                                            Console.WriteLine("Tipo de comprobante fiscal: " + resultadoF.tipoComprobante);
                                            Console.WriteLine("Comprobante Fiscal: " + resultadoF.comprobanteFiscal);
                                            Console.WriteLine("Metodo de pago de la factura: " + resultadoF.metodoPago);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    CoreService.Factura FacturaUpdate = new CoreService.Factura();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Factura que desea Actualizar");
                                        int UpdateFactura = Int32.Parse(Console.ReadLine());
                                        FacturaUpdate.noFactura = UpdateFactura;
                                        Console.WriteLine("Ingrese el nuevo Tipo de Comprobante Fiscal");
                                        FacturaUpdate.tipoComprobante = Console.ReadLine();
                                        Console.WriteLine("Ingrese el nuevo Comprobante Fiscal");
                                        FacturaUpdate.comprobanteFiscal = Console.ReadLine();
                                        Core.UpdateFacturaes(FacturaUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    CoreService.Factura FacturaDelete = new CoreService.Factura();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Factura que desea Borrar");
                                        int delFactura = Int32.Parse(Console.ReadLine());
                                        FacturaDelete.noFactura = delFactura;
                                        Core.DeleteFacturaes(FacturaDelete.noFactura);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Factura> lista = Core.GetFacturaes().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Factura item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("No. Factura: \t" + item.noFactura);
                                            Console.WriteLine("Id de la cotizacion: " + item.noCotizacion);
                                            Console.WriteLine("Id del cliente de la factura: " + item.cliente);
                                            Console.WriteLine("Tipo de comprobante fiscal: " + item.tipoComprobante);
                                            Console.WriteLine("Comprobante Fiscal: " + item.comprobanteFiscal);
                                            Console.WriteLine("Metodo de pago de la factura: " + item.metodoPago);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "10":
                            entity = "Cuentas_Cobrar";
                            SeleccionOpcion(entity);
                            OPCION = Console.ReadLine();
                            switch (OPCION)
                            {
                                case "1":
                                    Console.Clear();
                                    CoreService.Cuentas_Cobrar cc = new CoreService.Cuentas_Cobrar();
                                    try
                                    {
                                        Console.WriteLine("no. factura de la cuenta a cobrar:");
                                        cc.noFactura = Int32.Parse(Console.ReadLine());
                                        Core.RegistrarCuentaCobrar(cc);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Inserte el numero de factura");
                                        int cId = Int32.Parse(Console.ReadLine());
                                        CoreService.Cuentas_Cobrar resultadoC = Core.GetCuentaCobrar(cId);
                                        if (resultadoC != null)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("No. de factura: \t" + resultadoC.noFactura);
                                            Console.WriteLine("Monto de la Cuentas_Cobrar: " + resultadoC.montoDeuda);
                                            Console.WriteLine("fecha de pago de la Cuentas_Cobrar: " + resultadoC.fechaPago);
                                            Console.WriteLine("fecha limite de pago de la Cuentas_Cobrar: " + resultadoC.fechaLimitePago);
                                            Console.WriteLine("estado de pago de la Cuentas_Cobrar: " + resultadoC.estadoPago);
                                        }
                                        else
                                        {
                                            Console.WriteLine(mensajeError);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    CoreService.Cuentas_Cobrar Cuentas_CobrarUpdate = new CoreService.Cuentas_Cobrar();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el no. de factura, de la cuenta_cobrar que desea Actualizar");
                                        Cuentas_CobrarUpdate.noFactura = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese el nuevo estado de pago");
                                        Cuentas_CobrarUpdate.estadoPago = bool.Parse(Console.ReadLine());
                                        Core.UpdateCuentaCobrar(Cuentas_CobrarUpdate);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    Console.Clear();
                                    CoreService.Cuentas_Cobrar Cuentas_CobrarDelete = new CoreService.Cuentas_Cobrar();
                                    try
                                    {
                                        Console.WriteLine("Ingrese el Id del Cuentas_Cobrar que desea Borrar");
                                        int delCuentas_Cobrar = Int32.Parse(Console.ReadLine());
                                        Cuentas_CobrarDelete.noFactura = delCuentas_Cobrar;
                                        Core.DeleteCuentaCobrar(Cuentas_CobrarDelete);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(mensajeError2);
                                    }
                                    Console.ReadKey();
                                    break;
                                case "5":
                                    Console.Clear();
                                    List<CoreService.Cuentas_Cobrar> lista = Core.GetCuentasCobrar().ToList();
                                    if (lista.Any())
                                    {
                                        foreach (CoreService.Cuentas_Cobrar item in lista)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("No. de factura: \t" + item.noFactura);
                                            Console.WriteLine("Monto de la Cuentas_Cobrar: " + item.montoDeuda);
                                            Console.WriteLine("fecha de pago de la Cuentas_Cobrar: " + item.fechaPago);
                                            Console.WriteLine("fecha limite de pago de la Cuentas_Cobrar: " + item.fechaLimitePago);
                                            Console.WriteLine("estado de pago de la Cuentas_Cobrar: " + item.estadoPago);
                                        }
                                    }
                                    else if (!lista.Any())
                                    {
                                        Console.WriteLine(mensajeError);
                                    }
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("NO existe esta opcion");
                                    break;
                            }
                            break;
                        case "11":
                            AccesoHabilitado = false;
                            break;
                        case "12":
                            condicion = false;
                            break;
                        default:
                            Console.WriteLine("Esa no es una de las opciones");
                            break;
                    } 
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Por favor verifique que los datos ingresados son correctos");

                }
            }
            Console.WriteLine("Gracias por utilizar la aplicacion.");
            Environment.Exit(0);
        } 

        static public void SeleccionOpcion(string entidad)
        {
            Console.WriteLine("Seleccione la opcion que desea probar");
            Console.WriteLine("1. Registrar " + entidad);
            Console.WriteLine("2. Seleccionar " + entidad);
            Console.WriteLine("3. Actualizar " + entidad);
            Console.WriteLine("4. Eliminar " + entidad);
            Console.WriteLine("5. Traer Todos los registros de " + entidad);
        }

        static public bool ValidarUsuario(CoreService.Usuario user)
        {
            CoreService.TCCoreServiceSoapClient Core1 = new CoreService.TCCoreServiceSoapClient();
            List<CoreService.Usuario> listaUsuarios = Core1.GetUsuarios().ToList();
            foreach(CoreService.Usuario userData in listaUsuarios)
            {
                if (user.username == userData.username)
                {
                    Core1.Close();
                    return true;
                }
                else continue;
            }
            Core1.Close();
            return false;
        }

        static public bool ValidarContraseña(CoreService.Usuario user)
        {
            CoreService.TCCoreServiceSoapClient Core2 = new CoreService.TCCoreServiceSoapClient();
            List<CoreService.Usuario> listaUsuarios = Core2.GetUsuarios().ToList();
            foreach (CoreService.Usuario userData in listaUsuarios)
            {
                if (user.password == userData.password)
                {
                    Core2.Close();
                    return true;
                }
                else continue;
            }
            Core2.Close();
            return false;
        }
    }
}
