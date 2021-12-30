create database LosRapidosSAbd;


use LosRapidosSAbd;
CREATE TABLE Ambulancia
(
 
  Id_Ambulancia      int  identity (1,1) not null,
  modelo         VARCHAR (40) not null,
  tipoAmbulancia              VARCHAR (40) not null ,
  placa           VARCHAR (40) unique not null ,
  matricula                 VARCHAR(40)  not null ,
  fechaActivacion            VARCHAR(40) not null,
  estado	               VARCHAR(40) not null,
  observacion 		   VARCHAR(40) not null,
  Primary Key(Id_Ambulancia)
);

select *from Ambulancia;