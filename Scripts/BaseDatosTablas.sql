
CREATE DATABASE Pagadiario;
USE Pagadiario;

CREATE TABLE Cliente
(
	Cedula VARCHAR(20),
	Nombres VARCHAR(200),
	Telefono VARCHAR(50),
	Celular VARCHAR(50),
	Direccion VARCHAR(MAX),
	Notas VARCHAR(MAX),
	Activo BIT,
	ClienteId INT IDENTITY(1, 1) PRIMARY KEY
);

CREATE TABLE Prestamo
(
	[No] VARCHAR(10),
	Fecha DATE,
	Monto FLOAT,
	Interes FLOAT,
	FormaPago VARCHAR(20),
	FechaLimite DATE,
	TotalPagar FLOAT,
	Notas VARCHAR(MAX),
	Activo BIT,
	ClienteId INT FOREIGN KEY REFERENCES Cliente(ClienteId),
	PrestamoId INT IDENTITY(1, 1) PRIMARY KEY
);

CREATE TABLE Cobrador
(
	Cedula VARCHAR(20),
	Nombres VARCHAR(200),
	Telefono VARCHAR(50),
	Celular VARCHAR(50),
	Direccion VARCHAR(MAX),
	Notas VARCHAR(MAX),
	Activo BIT,
	CobradorId INT IDENTITY(1, 1) PRIMARY KEY
);

CREATE TABLE Pagos
(
	Fecha DATE,
	Pago FLOAT,
	ProximoPago DATE,
	Notas VARCHAR(MAX),
	Activo BIT,
	PrestamoId INT FOREIGN KEY REFERENCES Prestamo(PrestamoId),
	CobradorId INT FOREIGN KEY REFERENCES Cobrador(CobradorId),
	PagoId INT IDENTITY(1, 1) PRIMARY KEY
);