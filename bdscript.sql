CREATE DATABASE TechEmpire
GO
USE TechEmpire
GO


CREATE TABLE Productos(
CodigoProducto int,
Nombre varchar(50) NOT NULL,
Descripcion varchar(150) NOT NULL,
Marca varchar(50) NOT NULL,
Color varchar(50) NOT NULL,
ImgUrl varchar(150),
Precio float NOT NULL,
Stock smallint NOT NULL,
StockMinimo smallint NOT NULL,
StockMaximo smallint NOT NULL,
BorradoLogico bit
)


CREATE TABLE Roles
(
CodRol INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50)
)
GO


CREATE TABLE Usuarios(
NombreUsuario varchar(50) PRIMARY KEY,
DNI INT UNIQUE NOT NULL,
Nombre varchar(50) NOT NULL,
Apellido varchar(50) NOT NULL,
Mail varchar(100) NOT NULL,
Clave varchar(100) NOT NULL,
Rol INT FOREIGN KEY REFERENCES Roles(CodRol),
Bloqueo bit,
Activo bit,
ContFallidos smallint
);


GO
CREATE PROCEDURE ValidarUsuario
    @NombreUsuario varchar(50),
	@DNI int,
	@Email varchar(50)
AS
BEGIN
    SELECT * FROM Usuarios U 
	INNER JOIN Roles R ON U.Rol = R.CodRol
	WHERE NombreUsuario = @NombreUsuario OR DNI = @DNI OR Mail = @Email

END
GO




INSERT INTO Productos VALUES
(1, 'RTX 3090 NVIDIA MSI', 'Tamaño de la memoria: 24 GB GDDR6X', 'NVIDIA MSI', 'Negro', '', 1700000, 30, 20, 50, 0),
( 1, 'Teclado Razer', 'Switch Red','Razer', 'Negro', '', 200000, 30, 20, 50, 0);


INSERT INTO Roles VALUES('Admin')
INSERT INTO Roles VALUES('Cliente')
INSERT INTO Usuarios VALUES ('Admin', 12345678, 'Admin', 'admin@gmail.com', 'Admin', '5ac0852e770506dcd80f1a36d20ba7878bf82244b836d9324593bd14bc56dcb5', 1, 0, 1,0);