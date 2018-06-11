--use [clase22-05]



--create database  [clase22-05] --crea base de datos
--go

-- drop database [clase22-05]
-- drop table Productos --borrar tabla 

---------------------------------------------------------------------------------


create database SASAI
go

use SASAI

go


create table Usuarios (
CodUser varchar(20) not null,
contrasena varchar(50) not null,
acceso int not null,
constraint pk_claveUsuarios Primary Key (CodUser)
)

create table Movimientos (
CodMov int not null,
Usuario varchar (20) not null,
tablaModificada varchar (40) not null,
DatoModificado varchar (20) not null 
constraint pk_claveMovimientos Primary Key (Usuario,Codmov)

)

create table DetalleMov (

DatoMod varchar (20) not null,
Usuario varchar (20) not null,
Antes varchar (100) not null,
Despues varchar (100) not null,
fecha date not null,

constraint pk_claveDetalleMov primary key (Datomod,Usuario,fecha)
)



create table Materias (
CodMateria int  not null,
NombreMateria varchar(100)  not null,

constraint pk_claveMaterias Primary Key (CodMateria)

)


create table MateriasxCurso (
CodMateria int  not null,
Idcurso varchar(40)  not null,
constraint pk_claveMateriasxcurso Primary Key (CodMateria,idcurso)

)


create table MateriasAprobadasXalumnos (
DNI int  not null,
CodMateria varchar(100)  not null,
Idcurso varchar(40)  not null,
NotaMateria int not null,

constraint pk_claveMatAproAlum Primary Key (Dni,Codmateria,idcurso)

)


create table Interesados (
Email varchar(100)  not null,
Nombre varchar(50)  not null,
Apellido varchar(50)  not null,
FechaConsulta date not null,
constraint pk_claveInteresados Primary Key (Email)

)



create table Inscriptos (
DNI int  not null,
Idcurso varchar(40)  not null,
IDinscripto int not null,
Nombre varchar(50)  not null,
Apellido varchar(50)  not null,
Email varchar(100)  not null,
Telefono varchar(30)  not null,

Const_Analitico Bit not null default 0,
Const_Cuil  Bit not null default 0,
Fotoc_DNI  Bit not null default 0,
Foto4x4  Bit not null default 0,
Const_Trabajo  Bit not null default 0,
MontoPagar money not null,
FechaEntregaDoc date not null,
observaciones text, 
constraint pk_claveInscriptos Primary Key (DNI, Idcurso)

)

create table AlumnosxCurso (

DNI int  not null,
IDinscripto int not null,
codcurso varchar(40)  not null,
Modalidad varchar(18) not null default 'Mañana',
Turno varchar(18) not null,
MontoPagar money not null,

constraint pk_claveAlunosxcurso primary key (DNI, idinscripto,codcurso)

)


create table Cursos (
CodCurso varchar(40)  not null,
FechaI date  not null,
FechaF date not null,
NotaMinima int  not null default 0,
Capacidad int not null,
constraint pk_claveCursos Primary Key (CodCurso)

)

create table Preinscriptos (
DNI int  not null,
Idcurso varchar(40)  not null,
IDinscripto int not null,
Nombre varchar(50)  not null,
Apellido varchar(50)  not null,
Email varchar(100)  not null,
Telefono varchar(30)  not null,
DNIOLD int   not null default '0',
Turno varchar(60) not null,
Nacionalidad varchar(60) not null,
constraint pk_clavePreinscriptos Primary Key (DNI)

)







--go
----------------cargar tablas-----------

--insert into Articulos values('1','1','Pera','100','15')
--insert into Articulos values('2','2','Manzana','180','20')
--insert into Articulos values('3','3','cocoa','15','18')
--insert into Articulos values('4','4','caca','75','23')

--insert into Proveedores values ('1','Hernesto del valle','Montes de oca ','Tigre','Bs As','23407318372','1131193174','Pedro','xxx.xxx','nani@batman.com')


--------------- consultas -------------------

  
  
  
  

--  ---------------------- setear Sentencias ----------------------
--  --drop procedure MayoresA
--  create procedure MayoresA
--  @valor int 
--  as 
 
--select articulo, cantidad 
--from articulos
--  where cantidad > @valor
  
 
   
--  go
  
--  -----------------------------
 
--  MayoresA '80'
  
  
--  select *
--  from Articulos
  
--go

