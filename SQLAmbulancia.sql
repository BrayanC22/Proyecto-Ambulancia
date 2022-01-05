create database LosRapidosSAbd;


use grupo5;
CREATE TABLE Ambulancia
(
 
  Id_Ambulancia      int  identity (1,1) not null,
  modelo         VARCHAR (40) not null,
  tipoAmbulancia              VARCHAR (40) not null ,
  placa           VARCHAR (40) unique not null ,
  matricula                 VARCHAR(40) unique not null ,

  Primary Key(Id_Ambulancia)
);

select *from Ambulancia;
