﻿create database LosRapidosSAbd;


use LosRapidosSAbd;
CREATE TABLE Usuario
(
 
  Id_Usuario      int  identity (1,1) not null,
  Nombre         VARCHAR (40) not null,
  Apellido              VARCHAR (40) not null ,
  Cedula           VARCHAR (40) unique not null ,
  NombreUsuario                 VARCHAR(40)  not null ,
  Password            VARCHAR(40) not null,
  RutaImagen	               VARCHAR(500) not null,
  Primary Key(Id_Usuario));

  select * from Usuario;

  SELECT NombreUsuario, password FROM Usuario WHERE NombreUsuario = 'lino' AND password = '12345';
  -- drop table Usuario;