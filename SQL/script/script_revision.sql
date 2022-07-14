use pagoservicio
go 

create table usuario (
IdUsuario int identity(1,1),
CorreoElectronico varchar(200),
Contrasenia varchar(100)
)

drop table pago
create table pago 
(
IdPago int identity(1,1),
FechaPago datetime, 
CedulaCliente varchar(100),
IdServicio int, 
PagoProcesado bit,
Primary Key(IdPago)
)

insert into usuario (CorreoElectronico,Contrasenia)values('manuelchoez@gmail.com', '1234')
select  * from pago