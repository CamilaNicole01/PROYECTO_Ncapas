CREATE DATABASE Ventas
GO
--
USE Ventas
GO
--
--//Tabla Usuario//--
CREATE TABLE Usuario(
    IdUsuario INT IDENTITY(1,1) CONSTRAINT PKUsuario PRIMARY KEY,
	Identificacion VARCHAR(255) NOT NULL,
	NameUser VARCHAR(50) NOT NULL,
	Clave VARCHAR (50) NOT NULL, 
	IdTipoUsuario INT CONSTRAINT FKUsuarioTipoUsuario FOREIGN KEY REFERENCES TipoUsuario(ID),
	Estado TINYINT 
)
GO
--//REGISTRO USUARIO//--
INSERT INTO Usuario(Identificacion, NameUser, Clave,IdTipoUsuario, Estado)  
VALUES('Camila Nicole Campos Arias','Ccampos','123456', 1, 1)
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave, IdTipoUsuario, Estado)  
VALUES('Nadia Marissa Perez Gutierrez','Nnadia','885463', '2',1)
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave, IdTipoUsuario, Estado)  
VALUES('Delia Johana Torres Garcia','Ddelia','657469','3',1)
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave, IdTipoUsuario, Estado)  
VALUES('Edgar Rolando Equite Fuentes','Edgar','986546', '4',1)
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave, IdTipoUsuario, Estado)  
VALUES('Ana Francisca Armira Carreto','Aana','745673','5',1)
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave,IdTipoUsuario, Estado)  
VALUES('Ivan Alfredo Castillo Arevalo ','Iivan','326578', '6', 1)
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave ,IdTipoUsuario, Estado)  
VALUES('Rene Leonel Cruz Romero','Rrene','775564','7', 1)
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave ,IdTipoUsuario, Estado)  
VALUES('Sheyla Marleni Garcia Solares','Ssheyla','754687', '8', 1)
GO
--//TABLA TipoUsuario//--
CREATE TABLE TipoUsuario (
   ID INT IDENTITY(1,1) CONSTRAINT PKTipoUsuario PRIMARY KEY,
   Nombre VARCHAR(20) NOT NULL,
   Estado TINYINT 
)
GO
--//REGISTRO TipoUsuario//--
INSERT INTO TipoUsuario(Nombre, Estado)
VALUES('Admin', 1)
GO
INSERT INTO TipoUsuario(Nombre, Estado)
VALUES('Trabajos', 1)
GO
INSERT INTO TipoUsuario(Nombre, Estado)
VALUES('Reparto', 1)
GO
INSERT INTO TipoUsuario(Nombre, Estado)
VALUES('Sistema', 1)
GO
INSERT INTO TipoUsuario(Nombre, Estado)
VALUES('Propietario', 1)
GO
INSERT INTO TipoUsuario(Nombre, Estado)
VALUES('Gerente', 1)
GO
INSERT INTO TipoUsuario(Nombre, Estado)
VALUES('Supervisor', 1)
GO
INSERT INTO TipoUsuario(Nombre, Estado)
VALUES('Economia', 1)
GO
--
SELECT * FROM Usuario
---///////////////////////////////////////
--//TABLA CLIENTE//--
CREATE TABLE TipoCliente(
   ID INT IDENTITY(1,1) CONSTRAINT PKTipoCliente PRIMARY KEY,
   Tipo VARCHAR(50) NOT NULL,
   Estado TINYINT 
   )
GO
--//REGISTRO TipoCliente//--
INSERT INTO TipoCliente(Tipo, Estado)
VALUES('Frecuente', 1)
GO
INSERT INTO TipoCliente(Tipo, Estado)
VALUES('Habitual', 1)
GO
INSERT INTO TipoCliente(Tipo, Estado)
VALUES('Inactivo', 1)
GO
INSERT INTO TipoCliente(Tipo, Estado)
VALUES('Potencial', 1)
GO
--
SELECT * FROM TipoCliente
--
--//TablaCliente//-
CREATE TABLE Cliente(
    IdCliente INT IDENTITY(1,1) CONSTRAINT PKCliente PRIMARY KEY,
	Nombres VARCHAR(40) NOT NULL,
	Apellidos VARCHAR(40) NOT NULL,
	Correo VARCHAR(80) NOT NULL, 
	Ciudad VARCHAR (40) NULL,
	TipoCliente INT CONSTRAINT FKClienteTipoCliente FOREIGN KEY REFERENCES TipoCliente(ID),
	Estado TINYINT 
)
GO
--//RegistroCliente//---
INSERT INTO Cliente(Nombres, Apellidos, Correo, Ciudad, Estado)
VALUES('Antonio','Perez Tabique','Antperez@gmail','Chorrillos', 1)
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Ciudad, Estado)
VALUES('Benedicto ','Contreras Ramirez','Rramirez@gmail','Breña', 1)
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Ciudad, Estado)
VALUES('Ronaldo','Cruz Vela','cruzv@gmail','SJM', 1)
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Ciudad, Estado)
VALUES('Noe','Osorio Arias','osoa@gmail','Independencia', 1)
GO
--
SELECT * FROM Cliente
--//TABLA Producto//--
CREATE TABLE DetalleProducto(
    IdProducto INT IDENTITY(1,1) CONSTRAINT PKProducto PRIMARY KEY,
	Marca VARCHAR(100) NULL,
	Precio DECIMAL(10,2) NOT NULL,
	Stock INT NOT NULL,
	Observacion VARCHAR (255) NULL,
	IdNombreProducto INT CONSTRAINT FKDetalleProductoNombreProductos FOREIGN KEY REFERENCES NombreProductos(ID),
	Estado TINYINT 
)
GO
--
INSERT INTO DetalleProducto(Marca, Precio, Stock, Observacion, Estado)
VALUES('SONY','4000','50','INCLUYE Juego The Last Of Us 2 Play Station', 1)
GO
INSERT INTO DetalleProducto(Marca, Precio, Stock, Observacion, Estado)
VALUES('PLAY STATION','3200','10','NO INCLUYE ', 1)
GO
INSERT INTO DetalleProducto(Marca, Precio, Stock, Observacion, Estado)
VALUES('LG','1700','8','INCLUYE Funda de Silicona Protectora para Mando', 1)
GO
INSERT INTO DetalleProducto(Marca, Precio, Stock, Observacion, Estado)
VALUES('Apple','3000','8','NO INCLUYE', 1)
GO
INSERT INTO DetalleProducto(Marca, Precio, Stock, Observacion, Estado)
VALUES('Samsumg','1500','8','NO INCLUYE', 1)
GO
INSERT INTO DetalleProducto(Marca, Precio, Stock, Observacion, Estado)
VALUES('Nintendo','600','8','INCLUYE Game Boy, Wii', 1)
GO
--
SELECT * FROM DetalleProducto
--
--//TablaNombreProducto-//
CREATE TABLE NombreProductos(
   ID INT IDENTITY(1,1) CONSTRAINT PKNombreProductos PRIMARY KEY,
   Nombre VARCHAR(50) NOT NULL,
   Estado TINYINT 
   )
GO
--//REGISTRO NombreProductos//--
INSERT INTO NombreProductos(Nombre, Estado)
VALUES('PlayStation 5 PS5 CON RANURA DE DISCO', 1)
GO
INSERT INTO NombreProductos(Nombre, Estado)
VALUES('Consola PS4 Slim 1TB Jet Black', 1)
GO
INSERT INTO NombreProductos(Nombre, Estado)
VALUES('Mando PS4 Original Nuevo V2 Rojo', 1)
GO
INSERT INTO NombreProductos(Nombre, Estado)
VALUES('IPhone 13 Pro Max', 1)
GO
INSERT INTO NombreProductos(Nombre, Estado)
VALUES('Samsung QLED 4K 2021', 1)
GO
INSERT INTO NombreProductos(Nombre, Estado)
VALUES('Nintendo Switch', 1)
GO
SELECT * FROM NombreProductos
--
CREATE TABLE DetalleVenta(
    ID INT IDENTITY(1,1) CONSTRAINT PKProducto PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
	Total_Ventas VARCHAR(100) NULL,
)
GO

