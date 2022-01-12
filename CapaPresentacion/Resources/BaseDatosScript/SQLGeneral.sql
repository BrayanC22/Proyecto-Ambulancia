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


USE [LosRapidosSAbd]
GO

/******  Insertar Ambulancia *****/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[ambInsertCommand]
(
	@modelo varchar(40),
	@tipoAmbulancia varchar(40),
	@placa varchar(40),
	@matricula varchar(40)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Ambulancia] ([modelo], [tipoAmbulancia], [placa], [matricula]) VALUES (@modelo, @tipoAmbulancia, @placa, @matricula);
	
SELECT Id_Ambulancia, modelo, tipoAmbulancia, placa, matricula FROM Ambulancia WHERE (Id_Ambulancia = SCOPE_IDENTITY())
GO



/******  Buscar ******/

GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[ambSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        Ambulancia.*
FROM            Ambulancia
GO

/****** Buscar individual   ******/


USE [LosRapidosSAbd]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[ambSelectindividualCommand](
@placa varchar(40)
)
AS
	SET NOCOUNT ON;
SELECT        Ambulancia.*
FROM            Ambulancia
WHERE placa = @placa;

GO

/****** Delete Ambulancia ******/

USE [LosRapidosSAbd]
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[AmbDeleteCommand]
(
	@Original_placa varchar(40)
)
AS
SET NOCOUNT OFF;
DELETE FROM [Ambulancia] WHERE ([placa] = @Original_placa)
GO

/****** Update Ambulancia ******/


GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[ambUpdateCommand]
(
	@modelo varchar(40),
	@tipoAmbulancia varchar(40),
	@placa varchar(40),
	@matricula varchar(40)
)
AS
	SET NOCOUNT OFF;
UPDATE [Ambulancia] SET [modelo] = @modelo, [tipoAmbulancia] = @tipoAmbulancia, [matricula] = @matricula WHERE ([placa] = @placa);

GO
/* ---------------------- Asignacion ------------------------ */

CREATE TABLE Asignacion
(

  Id_Asignacion int identity (1,1) not null,
  Id_Ambulancia  int not null,
  Id_ConductorAsignacion  int not null,
  
  Primary Key(Id_Asignacion)
);


USE [LosRapidosSAbd]
GO

/****** INSERT ASIGNACION ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[AsignacionInsertCommand]
(
	@Id_Ambulancia int,
	@Id_ConductorAsignacion int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Asignacion] ([Id_Ambulancia], [Id_ConductorAsignacion]) VALUES (@Id_Ambulancia, @Id_ConductorAsignacion);
	
SELECT Id_Asignacion, Id_Ambulancia, Id_ConductorAsignacion FROM Asignacion WHERE (Id_Asignacion = SCOPE_IDENTITY())
GO

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