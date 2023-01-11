--Procedimientos almacenados CRUD
use TiendaColchones
go

/*========================================				   Usuario  					===========================================================*/

create procedure ppInsertUsuario
  @username nvarchar(70),
  @password nvarchar(70),
  @cedula nvarchar(11),
  @nombre nvarchar(70),
  @apellido nvarchar(70),
  @sexo char(1),
  @telefono nvarchar(10),
  @correo nvarchar(200)
as
	Insert into Usuario(username,password,nombre,apellido,cedula,correo,sexo,telefono) values
		(@username,@password,@nombre,@apellido,@cedula,@correo,@sexo,@telefono)
go

create procedure ppReadUsuario
as
	select * from Usuario
go

--create procedure ppUpdateUsuario
--	@usuarioId int,
--	@username varchar(70),
--	@password varchar(70)
--as
--	update Usuario
--	set username = iif(@username is null, username, @username), password = iif(@password is null,password, @password)
--	where id = @UsuarioId
--go

create procedure ppDeleteUsuario
	@UserId int
as
	Delete Usuario where id = @UserId
go


/*========================================				   Cliente  					===========================================================*/

create procedure ppInsertCliente
  @username nvarchar(70),
  @password nvarchar(70),
  @cedula nvarchar(11),
  @nombre nvarchar(70),
  @apellido nvarchar(70),
  @sexo char(1),
  @telefono nvarchar(10),
  @correo nvarchar(200)
as
	Insert into Cliente(username,password,nombre,apellido,cedula,correo,sexo,telefono) values
		(@username,@password,@nombre,@apellido,@cedula,@correo,@sexo,@telefono)
go

create procedure ppReadCliente
as
	select * from Cliente
go

--create procedure ppUpdateCliente
--	@clienteId int,
--	@username varchar(70),
--	@password varchar(70)
--as
--	update Usuario
--	set username = iif(@username is null, username, @username), password = iif(@password is null,password, @password)
--	where id = @clienteId
--go

create procedure ppDeleteCliente
	@targetCliente int
as
	delete Cliente where id = @targetCliente
go

/*========================================				     Rol  	    				===========================================================*/

create procedure ppInsertRol
	@rol varchar(60)
as
	insert into Rol(rol) values(@rol)
go

create procedure ppReadRol
as
	select * from Rol
go

--create procedure ppUpdateRol
--	@targetRol int,
--	@newRolName varchar(60)
--as
--	update Rol
--	set rol = iff(@newRolName is null, rol, @newRolName)
--go

create procedure ppDeleteRol
	@targetRol int
as
	Delete Rol where id = @targetRol
go

/*========================================				   Producto  					===========================================================*/

create procedure ppInsertProducto
	@productName varchar(70),
	@size varchar(6),
	@description text = 'n/a',
	@productPrice decimal(10,2) = 0,
	@stock int = 1
as
	insert into Producto(productName,size,description,productPrice,stock)
	values (@productName,@size,@description,@productPrice,@stock)
go

create procedure ppReadProducto
as
	select * from Producto
go

create procedure ppUpdateProductoInventario
	@targetProduct int,
	@changeStock int = 0
as
	update Producto
	set stock = stock + @changeStock
	where id = @targetProduct
go

create procedure ppDeleteProducto
	@targetProduct int
as
	Delete Producto where id = @targetProduct
go

/*========================================				   Servicio  					===========================================================*/

create procedure ppInsertServicio
	@serviceName varchar(70),
	@description text,
	@servicePrice decimal(10,2)
as
	insert into Servicio(serviceName,description,servicePrice)
	values (@serviceName,@description,@servicePrice)
go

create procedure ppReadServicio
as
	select * from Servicio
go

create procedure ppUpdatePrecioServicio
	@targetServicio int,
	@newPrecio decimal(10,2)
as
	update Servicio
	set servicePrice = iif(@newPrecio is null, servicePrice, @newPrecio)
	where id = @targetServicio
go

create procedure ppDeleteServicio
	@targetServicio int
as
	delete Servicio where id = @targetServicio
go

/*========================================		     Cotizacion_Producto  				===========================================================*/

create procedure ppInsertCotizacionProducto
	@noCotizacion int,
	@productId int,
	@cantidad int = 1
as
	declare @price decimal(10,2) set @price = (select productPrice from Producto where id = @productId)
	declare @subTotal decimal(10,2) set @subTotal = @cantidad * @price

	insert into Cotizacion_Producto(noCotizacion,productId,cantidad,subTotal)
	values (@noCotizacion,@productId,@cantidad,@subTotal)
go

create procedure ppReadCotizacionProducto
as
	select * from Cotizacion_Producto
go

create procedure ppUpdateCotizacionProducto
	@targetCotizacion int,
	@targetProduct int,
	@newCantidad int
as
	declare @price decimal(10,2) set @price = (select productPrice from Producto where id = @targetProduct)
	declare @subTotal decimal(10,2) set @subTotal = @newCantidad * @price

	update Cotizacion_Producto
	set cantidad = @newCantidad, subTotal = @subTotal
	where noCotizacion = @targetCotizacion and productId = @targetProduct
go

create procedure ppDeleteCotizacionProducto
	@targetCotizacion int,
	@targetProducto int
as
	delete Cotizacion_Producto where noCotizacion = @targetCotizacion and productId = @targetProducto
go

/*========================================		     Cotizacion_Servicio  				===========================================================*/

create procedure ppInsertCotizacionServicio
	@noCotizacion int,
	@serviceId int,
	@cantidad int = 1
as
	declare @price decimal(10,2) set @price = (select productPrice from Producto where id = @serviceId)
	declare @subTotal decimal(10,2) set @subTotal = @cantidad * @price

	insert into Cotizacion_Servicio(noCotizacion,serviceId,cantidad,subTotal)
	values (@noCotizacion,@serviceId,@cantidad,@subTotal)
go

create procedure ppReadCotizacionServicio
as
	select * from Cotizacion_Servicio
go

create procedure ppUpdateCotizacionServicio
	@targetCotizacion int,
	@targetServicio int,
	@newCantidad int
as
	declare @price decimal(10,2) set @price = (select servicePrice from Servicio where id = @targetServicio)
	declare @subTotal decimal(10,2) set @subTotal = @newCantidad * @price

	update Cotizacion_Servicio
	set cantidad = @newCantidad, subTotal = @subTotal
	where noCotizacion = @targetCotizacion and serviceId = @targetServicio
go

create procedure ppDeleteCotizacionServicio
	@targetCotizacion int,
	@targetServicio int
as
	delete Cotizacion_Servicio where noCotizacion = @targetCotizacion and serviceId = @targetServicio
go

/*========================================				 Cotizacion  					===========================================================*/

create procedure ppInsertCotizacion
	@cliente int,
	@subTotal decimal(10,2),
	@tax decimal(3,2),
	@total decimal(10,2)
as
	insert into Cotizacion(cliente,subTotal,tax,total) values (@cliente,@subTotal,@tax,@total)
go

create procedure ppReadCotizacion
as
	select * from Cotizacion
go

create procedure ppUpdateCotizacion
	@targetCotizacion int
as
	declare @subTotalProductos decimal(10,2) set @subTotalProductos = (select sum(subTotal) from Cotizacion_Producto where noCotizacion = @targetCotizacion)
	declare @subTotalServicios decimal(10,2) set @subTotalServicios = (select sum(subTotal) from Cotizacion_Servicio where noCotizacion = @targetCotizacion)
	declare @subTotal decimal(10,2) set @subTotal = iif(@subTotalProductos is null, 0, @subTotalProductos) + iif(@subTotalServicios is null, 0, @subTotalServicios)

	Update Cotizacion
	set subTotal = @subTotal, tax = tax * @subTotal, total = @subTotal + (tax * @subTotal)
	where noCotizacion = @targetCotizacion
go

create procedure ppDeleteCotizacion
	@targetCotizacion int
as
	Delete Cotizacion where noCotizacion = @targetCotizacion
go

/*========================================				   Factura  					===========================================================*/

create procedure ppInsertFactura
	@noCotizacion int,
	@cliente int,
	@tipoComprobante nvarchar(18) = 'Consumidor Final',
	@comprobanteFiscal nvarchar(13),
	@metodoPago nvarchar(20) = 'tarjeta' --modificar tabla para que la columan sea nvarchar(20)
as
	set @comprobanteFiscal = 'B000000000000'

	insert into Factura(noCotizacion,cliente,tipoComprobante,comprobanteFiscal,metodoPago) values
	(@noCotizacion,@cliente,@tipoComprobante,@comprobanteFiscal,@metodoPago)
go

create procedure ppReadFactura
as
	select * from Factura
go

create procedure ppUpdateFactura
	@targetFactura int,
	@tipoComprobante nvarchar(18),
	@comprobanteFiscal nvarchar(13)
as
	--agregar generación del comprobante fiscal

	update Factura
	set tipoComprobante = IIF(@tipoComprobante is null, tipoComprobante, @tipoComprobante), comprobanteFiscal = @comprobanteFiscal
	where noFactura = @targetFactura
go

create procedure ppDeleteFactura
	@targetFactura int
as
	delete Factura where noFactura = @targetFactura
go

/*========================================			    Cuentas_Cobrar	  				===========================================================*/

create procedure ppInsertCuentaCobrar
	@noFactura int
as
	Declare @montoDeuda decimal(10,2) set @montoDeuda = 
	(select total from Cotizacion where noCotizacion = (select noCotizacion from Factura where noFactura = @noFactura))

	Declare @fechaLimite datetime set @fechaLimite = (select GETDATE() + 7)

	insert into Cuentas_Cobrar(noFactura,montoDeuda,fechaPago,fechaLimitePago)
	values (@noFactura,@montoDeuda,null,@fechaLimite)
go

create procedure ppReadCuentaCobrar
as
	select * from Cuentas_Cobrar
go

create procedure ppUpdateCuentaCobrar
	@targetFactura int,
	@newEstadoPago bit
as
	if @newEstadoPago = 1
		begin
			update Cuentas_Cobrar
			set estadoPago = 1, fechaPago = GETDATE()
			where noFactura = @targetFactura
		end
	else
		return 0
go

create procedure ppDeleteCuentaCobrar
	@targetFactura int
as
	Delete Cuentas_Cobrar where noFactura = @targetFactura
go


/*====================================================================================================================================================*/
--select * from Cotizacion
--insert into Cotizacion(cliente,subTotal,tax,total) values(1,0,0,0)
--go
--select * from Producto

--exec ppInsertRol 'Admin'
--exec ppInsertRol 'Mantenimiento'
--exec ppInsertRol 'Consuta'
--exec ppInsertProducto 'Colchon A15','Full','n/a',15000,5
--exec ppInsertProducto 'Colchon A16','Full','n/a',20000,5
--exec ppInsertCliente 'Joel','12345678','Joel','Mauricio','12034567894','joel@email.com','M','8099990000'
--exec ppInsertUsuario 'Joel','123456789','Joel','Mauricio','10120120112','joel@email.com','M','8099990000'
--exec ppInsertCotizacion 1,0,0,0
--exec ppInsertCotizacionProducto 1,1,10
--exec ppInsertCotizacionProducto 1,2,10
--exec ppUpdateCotizacionProducto 1,2,9
--exec ppUpdateCotizacion 1
--exec ppReadCotizacion
--exec ppInsertFactura 1,1,default,''
--exec ppReadFactura
--exec ppInsertCuentaCobrar 1 
--exec ppReadCuentaCobrar

/*=================================================			Actualizaciones necesarioas		=========================================================*/

Create procedure ppGetCotizacionProducto
	@noCotizacion int,
	@idProducto int
as
	select * from Cotizacion_Producto where noCotizacion =@noCotizacion and productId = @idProducto
go

Create procedure ppGetProductsCotizacion
	@noCotizacion int
as
	select * from Cotizacion_Producto where noCotizacion =@noCotizacion
go

Create procedure ppGetCotizacionServicio
	@noCotizacion int,
	@idServicio int
as
	select * from Cotizacion_Servicio where noCotizacion =@noCotizacion and serviceId = @idServicio
go

Create procedure ppGetServicioCotizacion
	@noCotizacion int
as
	select * from Cotizacion_Servicio where noCotizacion = @noCotizacion
go

create procedure ppGetCuentaCobrar
	@noFactura int
as
	select * from Cuentas_Cobrar where noFactura = @noFactura
go
