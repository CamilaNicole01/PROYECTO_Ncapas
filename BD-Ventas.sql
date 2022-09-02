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
)
GO
--
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Camila Nicole Campos Arias','Ccampos','123456')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Nadia Marissa Perez Gutierrez','Nnadia','885463')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Delia Johana Torres Garcia','Ddelia','657469')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Edgar Rolando Equite Fuentes','Edgar','986546')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Ana Francisca Armira Carreto','Aana','745673')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Ivan Alfredo Castillo Arevalo ','Iivan','326578')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Josue Daniel Miranda Quevedo','Jjosue','7649334')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Raul Antonio Contreras Vela','Rraul','764568')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Rene Leonel Cruz Romero','Rrene','775564')
GO
INSERT INTO Usuario(Identificacion, NameUser, Clave)
VALUES('Sheyla Marleni Garcia Solares','Ssheyla','754687')
GO
--
SELECT * FROM Usuario
---///////////////////////////////////////
CREATE TABLE TipoCliente(
    IdTipo INT IDENTITY(1,1) CONSTRAINT PKTipoCliente PRIMARY KEY,
   Tipo VARCHAR(40) NOT NULL,
   Nombre VARCHAR(40) NOT NULL,
   )
GO
--
SELECT * FROM TipoCliente
INSERT INTO TipoCliente(Tipo, Nombre)
VALUES('Proveedor','Adquision de sofware')
GO
INSERT INTO TipoCliente(Tipo, Nombre)
VALUES('Consumidor','Sara Vela Ruiz')
GO
INSERT INTO TipoCliente(Tipo, Nombre)
VALUES('Proveedor','Play Station')
GO
--
--

CREATE TABLE Cliente(
    IdCliente INT IDENTITY(1,1) CONSTRAINT PKCliente PRIMARY KEY,
	Nombres VARCHAR(40) NOT NULL,
	Apellidos VARCHAR(40) NOT NULL,
	Correo VARCHAR(80) NOT NULL, 
	Observacion VARCHAR(120) NULL,
	Ciudad VARCHAR (40) NULL,
)
GO
--
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES('Antonio','Perez Tabique','Antperez@gmail','Frecuente','Chorrillos')
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES('Benedicto ','Contreras Ramirez','Rramirez@gmail','Frecuente','Breña')
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES('Edgar Elias','Suarez Lopez','Suarez@gmail','Habitual','Surco')
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES('Flavio Rodolfo ','Morales Puerta','Antperez@gmail','Frecuente','Lince')
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES('Sergio Danilo ','Morales Buchan','Moraly@gmail','Inactivo','Los olivos')
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES(' Rossanna Maribel ','Caceres Cortez','CaceRosa@gmail','Potencial','SJL')
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES('Olga Marina ','Bautista flores','floresb@gmail','Potencial','VMT')
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES('Ronaldo','Cruz Vela','cruzv@gmail','Frecuente','SJM')
GO
INSERT INTO Cliente(Nombres, Apellidos, Correo, Observacion, Ciudad)
VALUES('Noe','Osorio Arias','osoa@gmail','Inactivo','Independencia')
GO
--
--
CREATE TABLE Producto(
    IdProducto INT IDENTITY(1,1) CONSTRAINT PKProducto PRIMARY KEY,
	ListaProductos VARCHAR(100) NOT NULL,
	Marca VARCHAR(100) NULL,
	Precio DECIMAL(10,2) NOT NULL,
	Cantidad INT NOT NULL,
	Observacion VARCHAR (255) NULL,
)
GO
--
INSERT INTO Producto(ListaProductos, Marca, Precio, Cantidad, Observacion)
VALUES('PlayStation 5 PS5 CON RANURA DE DISCO','SONY','4000','50','INCLUYE Juego The Last Of Us 2 Play Station')
GO
INSERT INTO Producto(ListaProductos, Marca, Precio, Cantidad, Observacion)
VALUES('Consola PS4 Slim 1TB Jet Black','PLAY STATION','3200','10','INCLUYE ')
GO
INSERT INTO Producto(ListaProductos, Marca, Precio, Cantidad, Observacion)
VALUES('Mando PS4 Original Nuevo V2 Rojo','SONY','280','8','INCLUYE Funda de Silicona Protectora para Mando')
GO
INSERT INTO Producto(ListaProductos, Marca, Precio, Cantidad, Observacion)
VALUES('Timón con Pedal Logitech G29 para PS5 PS4 PS3','LOGITECH','1300','7','INCLUYE Ps4 Jgo Fifa 22 ')
GO
INSERT INTO Producto(ListaProductos, Marca, Precio, Cantidad, Observacion)
VALUES('Camara Playstation 5 Blanco','PLAY STATION','390','5','INCLUYE Just Dance 2021')
GO
SELECT * FROM Producto



