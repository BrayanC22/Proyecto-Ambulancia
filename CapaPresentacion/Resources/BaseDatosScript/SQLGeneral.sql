create database LosRapidosSAbd;
use LosRapidosSAbd;

/* ---------------------- USUARIO -------------------------- */
CREATE TABLE Usuario
(
 
  Id_Usuario      int  identity (1,1) not null,
  Nombre         VARCHAR (40) not null,
  Apellido              VARCHAR (40) not null ,
  Cedula           VARCHAR (10) unique not null ,
  NombreUsuario                 VARCHAR(40) unique not null ,
  Password            VARCHAR(40) not null,
  Foto	               image not null,
  Primary Key(Id_Usuario));
  -- drop table Usuario;

  -- Crear Stored procedured --

USE [LosRapidosSAbd]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[UsuarioInsertCommand]
(
	@Nombre varchar(40),
	@Apellido varchar(40),
	@Cedula varchar(10),
	@NombreUsuario varchar(40),
	@Password varchar(40),
	@Foto image
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Usuario] ([Nombre], [Apellido], [Cedula], [NombreUsuario], [Password], [Foto]) VALUES (@Nombre, @Apellido, @Cedula, @NombreUsuario, @Password, @Foto);
	
SELECT Id_Usuario, Nombre, Apellido, Cedula, NombreUsuario, Password, Foto FROM Usuario WHERE (Id_Usuario = SCOPE_IDENTITY())


GO

/* ---------------------- CLIENTE -------------------------- */

CREATE TABLE Cliente
(
  Id_Cliente      int  identity (1,1) not null,
  Cedula         VARCHAR (60) unique not null,
  Nombre             VARCHAR (60) not null ,
  Apellido           VARCHAR (60) not null ,
  Edad                 int  not null ,
  Domicilio           VARCHAR(60) not null,
  Sexo	               VARCHAR(60) not null,
  Imagen               VARCHAR(400) not null,
  CodigoCliente	        VARCHAR(60) not null,

  Primary Key(Id_Cliente)


);
-- drop table Cliente;
-- Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Imagen ,CodigoCliente from Cliente



/* --------------------- AMBULANCIA ------------------------ */

CREATE TABLE Ambulancia
(
 
  Id_Ambulancia      int  identity (1,1) not null,
  modelo         VARCHAR (40) not null,
  tipoAmbulancia              VARCHAR (40) not null ,
  placa           VARCHAR (40) unique not null,
  matricula                 VARCHAR(40) unique not null,
  Primary Key(Id_Ambulancia)
);
-- drop table Ambulancia;


/* ---------------------- CONDUCTOR ------------------------ */

CREATE TABLE Conductor
(
  Id_Conductor      int  identity (1,1) not null,
  Cedula         VARCHAR (60) unique not null,
  Nombre             VARCHAR (60) not null ,
  Apellido           VARCHAR (60) not null ,
  Edad                 int  not null ,
  Domicilio           VARCHAR(60) not null,
  Sexo	               VARCHAR(60) not null,
  Licencia             VARCHAR(60) not null,

  Primary Key(Id_Conductor)
);


/* ------------------------ PAGOS -------------------------- */