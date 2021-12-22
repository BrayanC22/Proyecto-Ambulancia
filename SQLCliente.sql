create database LosRapidosSAbd;


CREATE TABLE Cliente
(
  Id_Cliente      int  identity (1,1) not null,
  Cedula         VARCHAR (60) unique not null,
  Nombre             VARCHAR (60) not null ,
  Apellido           VARCHAR (60) not null ,
  Edad                 int  not null ,
  Domicilio           VARCHAR(60) not null,
  Sexo	               VARCHAR(60) not null,
  Imagen               VARCHAR(100) not null,
  CodigoCliente	        VARCHAR(60) not null,

  Primary Key(Id_Cliente)


);
drop table Cliente;
select *   from  Cliente;
Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Imagen ,CodigoCliente from Cliente



