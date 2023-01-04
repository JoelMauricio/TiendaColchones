create database TiendaColchones
go

--drop database TiendaColchones

use TiendaColchones
go


CREATE TABLE [Cliente] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [username] nvarchar(70) NOT NULL,
  [password] nvarchar(70) NOT NULL,
  [cedula] nvarchar(11) NOT NULL,
  [nombre] nvarchar(70) NOT NULL,
  [apellido] nvarchar(70) NOT NULL,
  [sexo] char(1) NOT NULL,
  [telefono] nvarchar(10) NOT NULL,
  [correo] nvarchar(200) NOT NULL,
  [state] bit NOT NULL DEFAULT (0)
)
GO

CREATE TABLE [Rol] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [rol] varchar(60) NOT NULL
)
GO

CREATE TABLE [Usuario] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [username] nvarchar(70) NOT NULL,
  [password] nvarchar(70) NOT NULL,
  [cedula] nvarchar(11) NOT NULL,
  [nombre] nvarchar(70) NOT NULL,
  [apellido] nvarchar(70) NOT NULL,
  [sexo] char(1) NOT NULL,
  [telefono] nvarchar(10) NOT NULL,
  [correo] nvarchar(200) NOT NULL,
  [rol] int NOT NULL DEFAULT (3),
  [state] bit NOT NULL DEFAULT (0)
)
GO

CREATE TABLE [Producto] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [productName] varchar(70) NOT NULL,
  [size] varchar(6) NOT NULL,
  [description] text NOT NULL,
  [productPrice] decimal(10,2) NOT NULL,
  [stock] int NOT NULL DEFAULT (1)
)
GO

CREATE TABLE [Servicio] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [serviceName] varchar(70) NOT NULL,
  [description] text not null default 'n/a',
  [servicePrice] decimal(10,2) NOT NULL
)
GO

CREATE TABLE [Cotizacion_Producto] (
  [noCotizacion] int NOT NULL,
  [productId] int,
  [cantidad] int NOT NULL DEFAULT (1),
  [subTotal] decimal(10,2) NOT NULL,
  unique(noCotizacion,productId)
)
GO

CREATE TABLE [Cotizacion_Servicio] (
  [noCotizacion] int NOT NULL,
  [serviceId] int,
  [cantidad] int NOT NULL DEFAULT (1),
  [subTotal] decimal(10,2) NOT NULL,
  unique(noCotizacion,serviceId)
)
GO

CREATE TABLE [Cotizacion] (
  [noCotizacion] int PRIMARY KEY IDENTITY(1, 1),
  [cliente] int NOT NULL,
  [subTotal] decimal(10,2) NOT NULL,
  [tax] decimal(3,2) DEFAULT (0.18),
  [total] decimal(10,2) NOT NULL,
  [created_at] datetime DEFAULT getdate(),
  [state] bit NOT NULL DEFAULT (0)
)
GO

CREATE TABLE [Factura] (
  [noFactura] int PRIMARY KEY IDENTITY(1, 1),
  [noCotizacion] int,
  [cliente] int NOT NULL,
  [tipoComprobante] nvarchar(18) NOT NULL DEFAULT 'Consumidor final',
  [comprobanteFiscal] nvarchar(13) NOT NULL,
  [metodoPago] nvarchar(20) NOT NULL DEFAULT 'Tarjeta',
  [created_at] datetime DEFAULT getdate(),
  [state] bit NOT NULL DEFAULT (0)
)
GO

CREATE TABLE [Cuentas_Cobrar] (
  [noFactura] int NOT NULL,
  [montoDeuda] decimal(10,2),
  [fechaPago] datetime,
  [fechaLimitePago] datetime,
  [estadoPago] bit NOT NULL DEFAULT (0)
)
GO

ALTER TABLE [Usuario] ADD FOREIGN KEY ([rol]) REFERENCES [Rol] ([id])
GO

ALTER TABLE [Cotizacion_Producto] ADD FOREIGN KEY ([productId]) REFERENCES [Producto] ([id])
GO

ALTER TABLE [Cotizacion_Producto] ADD FOREIGN KEY ([noCotizacion]) REFERENCES [Cotizacion] ([noCotizacion])
GO

ALTER TABLE [Cotizacion_Servicio] ADD FOREIGN KEY ([serviceId]) REFERENCES [Servicio] ([id])
GO

ALTER TABLE [Cotizacion_Servicio] ADD FOREIGN KEY ([noCotizacion]) REFERENCES [Cotizacion] ([noCotizacion])
GO

ALTER TABLE [Cotizacion] ADD FOREIGN KEY ([cliente]) REFERENCES [Cliente] ([id])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([noCotizacion]) REFERENCES [Cotizacion] ([noCotizacion])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([cliente]) REFERENCES [Cliente] ([id])
GO

ALTER TABLE [Cuentas_Cobrar] ADD FOREIGN KEY ([noFactura]) REFERENCES [Factura]([noFactura])
GO
