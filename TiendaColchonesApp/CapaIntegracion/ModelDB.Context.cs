﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaIntegracion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CITiendaDBEntities : DbContext
    {
        public CITiendaDBEntities()
            : base("name=CITiendaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cotizacion> Cotizacions { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Cotizacion_Producto> Cotizacion_Producto { get; set; }
        public virtual DbSet<Cotizacion_Servicio> Cotizacion_Servicio { get; set; }
        public virtual DbSet<Cuentas_Cobrar> Cuentas_Cobrar { get; set; }
    
        public virtual int ppDeleteCliente(Nullable<int> targetCliente)
        {
            var targetClienteParameter = targetCliente.HasValue ?
                new ObjectParameter("targetCliente", targetCliente) :
                new ObjectParameter("targetCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteCliente", targetClienteParameter);
        }
    
        public virtual int ppDeleteCotizacion(Nullable<int> targetCotizacion)
        {
            var targetCotizacionParameter = targetCotizacion.HasValue ?
                new ObjectParameter("targetCotizacion", targetCotizacion) :
                new ObjectParameter("targetCotizacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteCotizacion", targetCotizacionParameter);
        }
    
        public virtual int ppDeleteCotizacionProducto(Nullable<int> targetCotizacion, Nullable<int> targetProducto)
        {
            var targetCotizacionParameter = targetCotizacion.HasValue ?
                new ObjectParameter("targetCotizacion", targetCotizacion) :
                new ObjectParameter("targetCotizacion", typeof(int));
    
            var targetProductoParameter = targetProducto.HasValue ?
                new ObjectParameter("targetProducto", targetProducto) :
                new ObjectParameter("targetProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteCotizacionProducto", targetCotizacionParameter, targetProductoParameter);
        }
    
        public virtual int ppDeleteCotizacionServicio(Nullable<int> targetCotizacion, Nullable<int> targetServicio)
        {
            var targetCotizacionParameter = targetCotizacion.HasValue ?
                new ObjectParameter("targetCotizacion", targetCotizacion) :
                new ObjectParameter("targetCotizacion", typeof(int));
    
            var targetServicioParameter = targetServicio.HasValue ?
                new ObjectParameter("targetServicio", targetServicio) :
                new ObjectParameter("targetServicio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteCotizacionServicio", targetCotizacionParameter, targetServicioParameter);
        }
    
        public virtual int ppDeleteCuentaCobrar(Nullable<int> targetFactura)
        {
            var targetFacturaParameter = targetFactura.HasValue ?
                new ObjectParameter("targetFactura", targetFactura) :
                new ObjectParameter("targetFactura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteCuentaCobrar", targetFacturaParameter);
        }
    
        public virtual int ppDeleteFactura(Nullable<int> targetFactura)
        {
            var targetFacturaParameter = targetFactura.HasValue ?
                new ObjectParameter("targetFactura", targetFactura) :
                new ObjectParameter("targetFactura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteFactura", targetFacturaParameter);
        }
    
        public virtual int ppDeleteProducto(Nullable<int> targetProduct)
        {
            var targetProductParameter = targetProduct.HasValue ?
                new ObjectParameter("targetProduct", targetProduct) :
                new ObjectParameter("targetProduct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteProducto", targetProductParameter);
        }
    
        public virtual int ppDeleteRol(Nullable<int> targetRol)
        {
            var targetRolParameter = targetRol.HasValue ?
                new ObjectParameter("targetRol", targetRol) :
                new ObjectParameter("targetRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteRol", targetRolParameter);
        }
    
        public virtual int ppDeleteServicio(Nullable<int> targetServicio)
        {
            var targetServicioParameter = targetServicio.HasValue ?
                new ObjectParameter("targetServicio", targetServicio) :
                new ObjectParameter("targetServicio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteServicio", targetServicioParameter);
        }
    
        public virtual int ppDeleteUsuario(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppDeleteUsuario", userIdParameter);
        }
    
        public virtual ObjectResult<Cotizacion_Producto> ppGetCotizacionProducto(Nullable<int> noCotizacion, Nullable<int> idProducto)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Producto>("ppGetCotizacionProducto", noCotizacionParameter, idProductoParameter);
        }
    
        public virtual ObjectResult<Cotizacion_Producto> ppGetCotizacionProducto(Nullable<int> noCotizacion, Nullable<int> idProducto, MergeOption mergeOption)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Producto>("ppGetCotizacionProducto", mergeOption, noCotizacionParameter, idProductoParameter);
        }
    
        public virtual ObjectResult<Cotizacion_Servicio> ppGetCotizacionServicio(Nullable<int> noCotizacion, Nullable<int> idServicio)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            var idServicioParameter = idServicio.HasValue ?
                new ObjectParameter("idServicio", idServicio) :
                new ObjectParameter("idServicio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Servicio>("ppGetCotizacionServicio", noCotizacionParameter, idServicioParameter);
        }
    
        public virtual ObjectResult<Cotizacion_Servicio> ppGetCotizacionServicio(Nullable<int> noCotizacion, Nullable<int> idServicio, MergeOption mergeOption)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            var idServicioParameter = idServicio.HasValue ?
                new ObjectParameter("idServicio", idServicio) :
                new ObjectParameter("idServicio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Servicio>("ppGetCotizacionServicio", mergeOption, noCotizacionParameter, idServicioParameter);
        }
    
        public virtual ObjectResult<Cuentas_Cobrar> ppGetCuentaCobrar(Nullable<int> noFactura)
        {
            var noFacturaParameter = noFactura.HasValue ?
                new ObjectParameter("noFactura", noFactura) :
                new ObjectParameter("noFactura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cuentas_Cobrar>("ppGetCuentaCobrar", noFacturaParameter);
        }
    
        public virtual ObjectResult<Cuentas_Cobrar> ppGetCuentaCobrar(Nullable<int> noFactura, MergeOption mergeOption)
        {
            var noFacturaParameter = noFactura.HasValue ?
                new ObjectParameter("noFactura", noFactura) :
                new ObjectParameter("noFactura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cuentas_Cobrar>("ppGetCuentaCobrar", mergeOption, noFacturaParameter);
        }
    
        public virtual ObjectResult<Cotizacion_Producto> ppGetProductsCotizacion(Nullable<int> noCotizacion)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Producto>("ppGetProductsCotizacion", noCotizacionParameter);
        }
    
        public virtual ObjectResult<Cotizacion_Producto> ppGetProductsCotizacion(Nullable<int> noCotizacion, MergeOption mergeOption)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Producto>("ppGetProductsCotizacion", mergeOption, noCotizacionParameter);
        }
    
        public virtual ObjectResult<Cotizacion_Servicio> ppGetServicioCotizacion(Nullable<int> noCotizacion)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Servicio>("ppGetServicioCotizacion", noCotizacionParameter);
        }
    
        public virtual ObjectResult<Cotizacion_Servicio> ppGetServicioCotizacion(Nullable<int> noCotizacion, MergeOption mergeOption)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Servicio>("ppGetServicioCotizacion", mergeOption, noCotizacionParameter);
        }
    
        public virtual int ppInsertCliente(string username, string password, string cedula, string nombre, string apellido, string sexo, string telefono, string correo)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var cedulaParameter = cedula != null ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("sexo", sexo) :
                new ObjectParameter("sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertCliente", usernameParameter, passwordParameter, cedulaParameter, nombreParameter, apellidoParameter, sexoParameter, telefonoParameter, correoParameter);
        }
    
        public virtual int ppInsertCotizacion(Nullable<int> cliente, Nullable<decimal> subTotal, Nullable<decimal> tax, Nullable<decimal> total)
        {
            var clienteParameter = cliente.HasValue ?
                new ObjectParameter("cliente", cliente) :
                new ObjectParameter("cliente", typeof(int));
    
            var subTotalParameter = subTotal.HasValue ?
                new ObjectParameter("subTotal", subTotal) :
                new ObjectParameter("subTotal", typeof(decimal));
    
            var taxParameter = tax.HasValue ?
                new ObjectParameter("tax", tax) :
                new ObjectParameter("tax", typeof(decimal));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertCotizacion", clienteParameter, subTotalParameter, taxParameter, totalParameter);
        }
    
        public virtual int ppInsertCotizacionProducto(Nullable<int> noCotizacion, Nullable<int> productId, Nullable<int> cantidad)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("productId", productId) :
                new ObjectParameter("productId", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertCotizacionProducto", noCotizacionParameter, productIdParameter, cantidadParameter);
        }
    
        public virtual int ppInsertCotizacionServicio(Nullable<int> noCotizacion, Nullable<int> serviceId, Nullable<int> cantidad)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            var serviceIdParameter = serviceId.HasValue ?
                new ObjectParameter("serviceId", serviceId) :
                new ObjectParameter("serviceId", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertCotizacionServicio", noCotizacionParameter, serviceIdParameter, cantidadParameter);
        }
    
        public virtual int ppInsertCuentaCobrar(Nullable<int> noFactura)
        {
            var noFacturaParameter = noFactura.HasValue ?
                new ObjectParameter("noFactura", noFactura) :
                new ObjectParameter("noFactura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertCuentaCobrar", noFacturaParameter);
        }
    
        public virtual int ppInsertFactura(Nullable<int> noCotizacion, Nullable<int> cliente, string tipoComprobante, string comprobanteFiscal, string metodoPago)
        {
            var noCotizacionParameter = noCotizacion.HasValue ?
                new ObjectParameter("noCotizacion", noCotizacion) :
                new ObjectParameter("noCotizacion", typeof(int));
    
            var clienteParameter = cliente.HasValue ?
                new ObjectParameter("cliente", cliente) :
                new ObjectParameter("cliente", typeof(int));
    
            var tipoComprobanteParameter = tipoComprobante != null ?
                new ObjectParameter("tipoComprobante", tipoComprobante) :
                new ObjectParameter("tipoComprobante", typeof(string));
    
            var comprobanteFiscalParameter = comprobanteFiscal != null ?
                new ObjectParameter("comprobanteFiscal", comprobanteFiscal) :
                new ObjectParameter("comprobanteFiscal", typeof(string));
    
            var metodoPagoParameter = metodoPago != null ?
                new ObjectParameter("metodoPago", metodoPago) :
                new ObjectParameter("metodoPago", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertFactura", noCotizacionParameter, clienteParameter, tipoComprobanteParameter, comprobanteFiscalParameter, metodoPagoParameter);
        }
    
        public virtual int ppInsertProducto(string productName, string size, string description, Nullable<decimal> productPrice, Nullable<int> stock)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var sizeParameter = size != null ?
                new ObjectParameter("size", size) :
                new ObjectParameter("size", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var productPriceParameter = productPrice.HasValue ?
                new ObjectParameter("productPrice", productPrice) :
                new ObjectParameter("productPrice", typeof(decimal));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("stock", stock) :
                new ObjectParameter("stock", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertProducto", productNameParameter, sizeParameter, descriptionParameter, productPriceParameter, stockParameter);
        }
    
        public virtual int ppInsertRol(string rol)
        {
            var rolParameter = rol != null ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertRol", rolParameter);
        }
    
        public virtual int ppInsertServicio(string serviceName, string description, Nullable<decimal> servicePrice)
        {
            var serviceNameParameter = serviceName != null ?
                new ObjectParameter("serviceName", serviceName) :
                new ObjectParameter("serviceName", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var servicePriceParameter = servicePrice.HasValue ?
                new ObjectParameter("servicePrice", servicePrice) :
                new ObjectParameter("servicePrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertServicio", serviceNameParameter, descriptionParameter, servicePriceParameter);
        }
    
        public virtual int ppInsertUsuario(string username, string password, string cedula, string nombre, string apellido, string sexo, string telefono, string correo)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var cedulaParameter = cedula != null ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("sexo", sexo) :
                new ObjectParameter("sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppInsertUsuario", usernameParameter, passwordParameter, cedulaParameter, nombreParameter, apellidoParameter, sexoParameter, telefonoParameter, correoParameter);
        }
    
        public virtual ObjectResult<Cliente> ppReadCliente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cliente>("ppReadCliente");
        }
    
        public virtual ObjectResult<Cliente> ppReadCliente(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cliente>("ppReadCliente", mergeOption);
        }
    
        public virtual ObjectResult<Cotizacion> ppReadCotizacion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion>("ppReadCotizacion");
        }
    
        public virtual ObjectResult<Cotizacion> ppReadCotizacion(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion>("ppReadCotizacion", mergeOption);
        }
    
        public virtual ObjectResult<Cotizacion_Producto> ppReadCotizacionProducto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Producto>("ppReadCotizacionProducto");
        }
    
        public virtual ObjectResult<Cotizacion_Producto> ppReadCotizacionProducto(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Producto>("ppReadCotizacionProducto", mergeOption);
        }
    
        public virtual ObjectResult<Cotizacion_Servicio> ppReadCotizacionServicio()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Servicio>("ppReadCotizacionServicio");
        }
    
        public virtual ObjectResult<Cotizacion_Servicio> ppReadCotizacionServicio(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cotizacion_Servicio>("ppReadCotizacionServicio", mergeOption);
        }
    
        public virtual ObjectResult<Cuentas_Cobrar> ppReadCuentaCobrar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cuentas_Cobrar>("ppReadCuentaCobrar");
        }
    
        public virtual ObjectResult<Cuentas_Cobrar> ppReadCuentaCobrar(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cuentas_Cobrar>("ppReadCuentaCobrar", mergeOption);
        }
    
        public virtual ObjectResult<Factura> ppReadFactura()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Factura>("ppReadFactura");
        }
    
        public virtual ObjectResult<Factura> ppReadFactura(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Factura>("ppReadFactura", mergeOption);
        }
    
        public virtual ObjectResult<Producto> ppReadProducto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Producto>("ppReadProducto");
        }
    
        public virtual ObjectResult<Producto> ppReadProducto(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Producto>("ppReadProducto", mergeOption);
        }
    
        public virtual ObjectResult<Rol> ppReadRol()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Rol>("ppReadRol");
        }
    
        public virtual ObjectResult<Rol> ppReadRol(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Rol>("ppReadRol", mergeOption);
        }
    
        public virtual ObjectResult<Servicio> ppReadServicio()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Servicio>("ppReadServicio");
        }
    
        public virtual ObjectResult<Servicio> ppReadServicio(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Servicio>("ppReadServicio", mergeOption);
        }
    
        public virtual ObjectResult<Usuario> ppReadUsuario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usuario>("ppReadUsuario");
        }
    
        public virtual ObjectResult<Usuario> ppReadUsuario(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usuario>("ppReadUsuario", mergeOption);
        }
    
        public virtual int ppUpdateCotizacion(Nullable<int> targetCotizacion)
        {
            var targetCotizacionParameter = targetCotizacion.HasValue ?
                new ObjectParameter("targetCotizacion", targetCotizacion) :
                new ObjectParameter("targetCotizacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppUpdateCotizacion", targetCotizacionParameter);
        }
    
        public virtual int ppUpdateCotizacionProducto(Nullable<int> targetCotizacion, Nullable<int> targetProduct, Nullable<int> newCantidad)
        {
            var targetCotizacionParameter = targetCotizacion.HasValue ?
                new ObjectParameter("targetCotizacion", targetCotizacion) :
                new ObjectParameter("targetCotizacion", typeof(int));
    
            var targetProductParameter = targetProduct.HasValue ?
                new ObjectParameter("targetProduct", targetProduct) :
                new ObjectParameter("targetProduct", typeof(int));
    
            var newCantidadParameter = newCantidad.HasValue ?
                new ObjectParameter("newCantidad", newCantidad) :
                new ObjectParameter("newCantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppUpdateCotizacionProducto", targetCotizacionParameter, targetProductParameter, newCantidadParameter);
        }
    
        public virtual int ppUpdateCotizacionServicio(Nullable<int> targetCotizacion, Nullable<int> targetServicio, Nullable<int> newCantidad)
        {
            var targetCotizacionParameter = targetCotizacion.HasValue ?
                new ObjectParameter("targetCotizacion", targetCotizacion) :
                new ObjectParameter("targetCotizacion", typeof(int));
    
            var targetServicioParameter = targetServicio.HasValue ?
                new ObjectParameter("targetServicio", targetServicio) :
                new ObjectParameter("targetServicio", typeof(int));
    
            var newCantidadParameter = newCantidad.HasValue ?
                new ObjectParameter("newCantidad", newCantidad) :
                new ObjectParameter("newCantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppUpdateCotizacionServicio", targetCotizacionParameter, targetServicioParameter, newCantidadParameter);
        }
    
        public virtual int ppUpdateCuentaCobrar(Nullable<int> targetFactura, Nullable<bool> newEstadoPago)
        {
            var targetFacturaParameter = targetFactura.HasValue ?
                new ObjectParameter("targetFactura", targetFactura) :
                new ObjectParameter("targetFactura", typeof(int));
    
            var newEstadoPagoParameter = newEstadoPago.HasValue ?
                new ObjectParameter("newEstadoPago", newEstadoPago) :
                new ObjectParameter("newEstadoPago", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppUpdateCuentaCobrar", targetFacturaParameter, newEstadoPagoParameter);
        }
    
        public virtual int ppUpdateFactura(Nullable<int> targetFactura, string tipoComprobante, string comprobanteFiscal)
        {
            var targetFacturaParameter = targetFactura.HasValue ?
                new ObjectParameter("targetFactura", targetFactura) :
                new ObjectParameter("targetFactura", typeof(int));
    
            var tipoComprobanteParameter = tipoComprobante != null ?
                new ObjectParameter("tipoComprobante", tipoComprobante) :
                new ObjectParameter("tipoComprobante", typeof(string));
    
            var comprobanteFiscalParameter = comprobanteFiscal != null ?
                new ObjectParameter("comprobanteFiscal", comprobanteFiscal) :
                new ObjectParameter("comprobanteFiscal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppUpdateFactura", targetFacturaParameter, tipoComprobanteParameter, comprobanteFiscalParameter);
        }
    
        public virtual int ppUpdatePrecioServicio(Nullable<int> targetServicio, Nullable<decimal> newPrecio)
        {
            var targetServicioParameter = targetServicio.HasValue ?
                new ObjectParameter("targetServicio", targetServicio) :
                new ObjectParameter("targetServicio", typeof(int));
    
            var newPrecioParameter = newPrecio.HasValue ?
                new ObjectParameter("newPrecio", newPrecio) :
                new ObjectParameter("newPrecio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppUpdatePrecioServicio", targetServicioParameter, newPrecioParameter);
        }
    
        public virtual int ppUpdateProductoInventario(Nullable<int> targetProduct, Nullable<int> changeStock)
        {
            var targetProductParameter = targetProduct.HasValue ?
                new ObjectParameter("targetProduct", targetProduct) :
                new ObjectParameter("targetProduct", typeof(int));
    
            var changeStockParameter = changeStock.HasValue ?
                new ObjectParameter("changeStock", changeStock) :
                new ObjectParameter("changeStock", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ppUpdateProductoInventario", targetProductParameter, changeStockParameter);
        }
    }
}
