

use master

create database SASAI
go
use SASAI

go
create table Usuarios (
usuario varchar(20) not null,
contrasena varchar(50) not null,
acceso int not null,
constraint pk_claveUsuarios Primary Key (usuario)
)
create table Movimientos (
CodMov int not null,
Usuario varchar (20) not null,
tablaModificada varchar (40) not null,
DatoModificado varchar (20) not null ,
fecha date not null
constraint pk_claveMovimientos Primary Key (Usuario,Codmov,fecha)
)

create table DetalleMov (
CodMov int not null,
Usuario varchar (20) not null,
Antes varchar (100) not null,
Despues varchar (100) not null,
fecha date not null 
constraint pk_claveDetalleMov primary key (codmov,Usuario,fecha)
)
create table Materias (
CodMateria varchar(40)  not null,
NombreMateria varchar(100)  not null,
Monto money not null,
constraint pk_claveMaterias Primary Key (CodMateria)

)
create table MateriasxCurso (
CodMateria varchar(40)  not null,
CodCurso varchar(40)  not null,
CodEspecialidad varchar(40) not null,
constraint pk_claveMateriasxcurso Primary Key (CodMateria,CodCurso,codespecialidad)

)
create table Cursos(
CodCurso varchar(40)  not null,
FechaInicio date,
FechaFinal date,
Nota_Min int not null,
CapacidadMax int ,
constraint pk_Cursos Primary Key (codcurso)

)
create table EspecialidadesXCursos (

CodCurso varchar(40) not null,
CodEspecialidad varchar(40) not null,
constraint pk_EspecialidadesXCurso Primary Key(codcurso,CodEspecialidad)

)
create table Especialidades (
Codespecialidad varchar(40) not null,
nombre varchar(40) not  null,
AniosAprox int not null,

constraint pk_Especialidades Primary Key(codEspecialidad) 
)
create table AlumnosxMateriasxCursos (
DNI int  not null,
CodMateria varchar(40)  not null,
Codcurso varchar(40)  not null,
CodEspecialidad varchar(40),
NotaMateria int not null,
constraint pk_claveMatAproAlum Primary Key (Dni,Codmateria,codcurso)
)

create table Inscriptos (
DNI int  not null,
codcurso varchar(40)  not null,
IDinscripto int not null,
Nombre varchar(50)  not null,
Apellido varchar(50)  not null,
Email varchar(100)  not null,
Telefono varchar(50)  not null,

Const_Analitico Bit not null default 0,
Const_Cuil  Bit not null default 0,
Fotoc_DNI  Bit not null default 0,
Foto4x4  Bit not null default 0,
Const_Trabajo  Bit not null default 0,
MontoPagar money not null,
FechaEntregaDoc date not null,
observaciones text, 
constraint pk_claveInscriptos Primary Key (DNI)
)

create table Interesados (
Email varchar(100)  not null,
Nombre varchar(50)  not null,
Apellido varchar(50)  not null,
FechaConsulta date not null,
constraint pk_claveInteresados Primary Key (Email)

)

create table Preinscriptos (
DNI int  not null,
codcurso varchar(40) not null default '0' ,
IDinscripto int not null default '0',
Nombre varchar(50)  not null,
Apellido varchar(50)  not null ,
Email varchar(100)  not null default '',
Telefono varchar(30)  not null default '0',
DNIOLD int   not null default '0',
Turno varchar(60) not null default'Mañana',
Nacionalidad varchar(60) not null ,
constraint pk_clavePreinscriptos Primary Key (DNI)

)
go
-----------------conecciones de tablas---------
use SASAI
go

 --------- tabla especialidad x cursos
alter table EspecialidadesxCursos add constraint Fk_EspecialidadesxCursoxEsp
foreign key (Codespecialidad) references Especialidades (codespecialidad)
alter table EspecialidadesxCursos add constraint Fk_EspecialidadesxCursoxCurso
foreign key (codCurso) references Cursos (Codcurso)
------------ tabla materias  x curso
alter table Materiasxcurso add constraint Fk_MateriasxCursoxMaterias
foreign key (CodMateria) references Materias(Codmateria)
alter table Materiasxcurso add constraint Fk_MateriasxCursoxEspeXCursos
 foreign key (codcurso,codespecialidad) references EspecialidadesxCursos (codcurso,codespecialidad)  
----------- tabla alumnos por materia x curso
alter table AlumnosxMateriasxCursos add constraint Fk_AlumnosxMateriasxCursosxMate
foreign key (CodMateria,CodCurso,Codespecialidad) 
references MateriasxCurso(CodMateria,CodCurso,CodEspecialidad)
alter table alumnosxMateriasxCursos add constraint Fk_AlumnosxMateriasxCursosxIscriptos
foreign key (DNI) references Inscriptos (DNI)
----------- tabla Movimientos
alter table Movimientos add constraint Fk_MovimientosxUsuario
foreign key (Usuario) references Usuarios (usuario)
----------- tabla DetalleMov
---error aca
alter table DetalleMov add constraint Fk_DetalleMovxMov
foreign key (usuario,codmov,fecha) references Movimientos (usuario,codmov,fecha)
-----------
---------------------------- procedure
go
create procedure VerificarUsuario
@nombre varchar(20), @contrasena varchar(20)
as


select count (usuario)
from Usuarios
where usuario=@nombre and contrasena = @contrasena

go

insert into usuarios (usuario,contrasena,acceso)
select 'nehuen','123',10
go

create procedure EliminarUsuario
@user varchar(20)

AS
    DELETE FROM USUARIOS
    WHERE Usuario=@user
    RETURN
    go


VerificarUsuario 'nehuen','123'

