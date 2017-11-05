use master

create database proyecto
use proyecto

create table platos(
platoId int not null identity(1,1),
 
platoNombre varchar(30) unique not null check(DATALENGTH(platoNombre)>0) ,
  
platodescrip varchar(150) not null check(DATALENGTH(platodescrip)>0) ,

platoprice numeric(18,2) not null check(DATALENGTH(platoprice)>0) , 
 
imageUrl varchar(200) not null check(DATALENGTH(imageUrl)>0),
primary key (platoId)
)
select * from platos
insert into platos values('Verdura','Contiene zanahoria, brocoli y especias',15.5,'https://openclipart.org/image/300px/svg_to_png/275577/1489583612.png');


insert into platos values('Tortilla','Contiene trigo y frutos secos',10.9,'https://openclipart.org/image/300px/svg_to_png/209695/food-tortilla.png');

create table Clientes2(
IDCliente int identity(1,1) primary key,
NombreCliente varchar(30) not null check(DATALENGTH(NombreCliente)>0),
ApellidosCliente varchar(30) not null check(DATALENGTH(ApellidosCliente)>0) ,
Dni numeric(8) unique not null check(DATALENGTH(Dni)>0), 
Direccion varchar(30) not null check(DATALENGTH(Direccion)>0),
TelefonoCliente int not null check(DATALENGTH(TelefonoCliente)>0),
Email varchar(30) unique  not null check(DATALENGTH(Email)>0),
Password varchar(16) not null check(DATALENGTH(Password)>0),
esAdmin bit not null
)
insert into Clientes2 values('arturo','asto',12345678,'casa',9998998,'admin','admin','1');
insert into Clientes2 values('wilfrid','galan',12345677,'casa',9998998,'test','test','0');

select * from Clientes2