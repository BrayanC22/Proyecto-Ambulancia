create database LosRapidosSAbd;


use grupo5;
CREATE TABLE Usuario
(
 
  Id_Usuario      int  identity (1,1) not null,
  Nombre         VARCHAR (40) not null,
  Apellido              VARCHAR (40) not null ,
  Cedula           VARCHAR (40) unique not null ,
  Correo                 VARCHAR(40)  not null ,
  Password            VARCHAR(40) not null,
  RutaImagen	               VARCHAR(40) not null,
  Primary Ke(Id_Usuario))
);