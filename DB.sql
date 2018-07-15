--use master
--drop database sasai

--create database SASAI
--go

--use SASAI
--go
create table Usuarios (
usuario varchar(20) not null,
contrasena varchar(20) not null,
acceso int not null,
baja bit not null default 0,
constraint pk_claveUsuarios Primary Key (usuario)
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
actual int default 0 ,
constraint pk_Cursos Primary Key (codcurso)

)
create table EspecialidadesXCursos (

CodCurso varchar(40) not null,
CodEspecialidad varchar(40) not null,
constraint pk_EspecialidadesXCurso Primary Key(codcurso,CodEspecialidad)

)
create table Especialidades (
Codespecialidad varchar(40) not null,
nombre varchar(100) not  null,
AniosAprox int not null,

constraint pk_Especialidades Primary Key(codEspecialidad) 
)
create table AlumnosxMateriasxCursos (
DNI int  not null,
CodMateria varchar(40)  not null,
Codcurso varchar(40)  not null,
CodEspecialidad varchar(40),
NotaMateria int not null,
usuario varchar(20) not null,
idInscripto int not null,
MontoaPagar money not null,
constraint pk_claveMatAproAlum Primary Key (Dni,Codmateria,codcurso)
)
create table Inscriptos (
DNI int  not null,
Nombre varchar(50)  not null,
Apellido varchar(50)  not null,
UltimoCurso varchar(40)not null,
Email varchar(100)  not null,
Telefono varchar(50)  not null,
Activo bit not null default 1,

Const_Analitico Bit not null default 0,
Const_Cuil  Bit not null default 0,
Fotoc_DNI  Bit not null default 0,
Foto4x4  Bit not null default 0,
Const_Trabajo  Bit not null default 0,
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
Modalidad varchar(60) not null ,
Usuario varchar(20) not null,
baja bit default 0,
constraint pk_clavePreinscriptos Primary Key (DNI)

)
create table ControlAlumxMatexCurso (
  TipoTrn char(1), 
  Tabla varchar(128), 
  PK varchar(1000), 
  Campo varchar(128), 
  ValorOriginal varchar(1000), 
  ValorNuevo varchar(1000), 
  FechaTrn datetime, Usuario varchar(128)
  )
CREATE TABLE ControlPreinscriptos (
  TipoTrn char(1), 
  Tabla varchar(128), 
  PK varchar(1000), 
  Campo varchar(128), 
  ValorOriginal varchar(1000), 
  ValorNuevo varchar(1000), 
  FechaTrn datetime, Usuario varchar(128))
go
-----------------conecciones de tablas-------------------------------------------------------------------------------------
use SASAI
 --------- tabla especialidad x cursos-------------------------------------------------------------------------------------
alter table EspecialidadesxCursos add constraint Fk_EspecialidadesxCursoxEsp
foreign key (Codespecialidad) references Especialidades (codespecialidad)
alter table EspecialidadesxCursos add constraint Fk_EspecialidadesxCursoxCurso
foreign key (codCurso) references Cursos (Codcurso)
------- tabla materias  x curso--------------------------------------------------------------------------------------------
alter table Materiasxcurso add constraint Fk_MateriasxCursoxMaterias
foreign key (CodMateria) references Materias(Codmateria)
alter table Materiasxcurso add constraint Fk_MateriasxCursoxEspeXCursos
 foreign key (codcurso,codespecialidad) references EspecialidadesxCursos (codcurso,codespecialidad)  
------- tabla alumnos por materia x curso----------------------------------------------------------------------------------
alter table AlumnosxMateriasxCursos add constraint Fk_AlumnosxMateriasxCursosxMate
foreign key (CodMateria,CodCurso,Codespecialidad) 
references MateriasxCurso(CodMateria,CodCurso,CodEspecialidad)
alter table alumnosxMateriasxCursos add constraint Fk_AlumnosxMateriasxCursosxIscriptos
foreign key (DNI) references Inscriptos (DNI)
----------- tabla Movimientos----------------------------------------------------------------------------------------------

-----------------------carga valores tabla---------------------------------------------------------------------------------

insert into usuarios (usuario,contrasena,acceso,baja)
select 'admin','',6,1 union
select 'nehuen','123',10,0 union 
select 'pedron','123',9,1 union
select 'leandro','123',8,0 union
select 'mariano','123',5,0 union
select 'batman','123',7,0 union
select 'robin','123',6,1 

go

select * from EspecialidadesXCursos
go

insert into Especialidades(Codespecialidad,nombre,AniosAprox)
select '001','Tecnicatura Superior en Programacion',2 union
select '002','Tecnicatura Superior en Sistemas Informaticos',1 union
select '003','Ingenieria Mecanica',5 union
select '004','Ingenieria Electrica',5 union
select '005','Ingenieria Civil',5
go


insert into EspecialidadesXCursos(CodCurso,CodEspecialidad)
select '001','001' union
select '002','001' union
select '003','001' union
select '002','002' 
go


insert into Materias(CodMateria,NombreMateria,Monto)
select '001','Matematica',800 union
select '002','Introduccion a la Programacion',800 union
select '003','Introduccion a la Informatica',600
go


insert into Cursos(CodCurso,FechaInicio,FechaFinal,Nota_Min,CapacidadMax,actual)
select '001','10/04/2018','09/06/2018',6,100,0 union
select '002','10/06/2018','09/08/2018',6,100,1 union
select '003','10/08/2018','10/10/2018',6,100,0 
go


select * from Cursos


insert into Inscriptos(DNI,Nombre,Apellido,UltimoCurso,Email,Telefono,Activo,Const_Analitico,Const_Cuil,Fotoc_DNI,Foto4x4,Const_Trabajo,FechaEntregaDoc)
select 40459112, 'leandro', 'arroyo', '002', 'martin_arroyo@hotmail.es', 1161595480, 1, 1, 1, 1, 1,1, '15/07/2018' union
select 40459113, 'mariano', 'perez', '002', 'mariano@hotmail.es', 1161595481, 1, 1, 1, 1, 1,1, '15/07/2018' union
select 40459114, 'nehuen', 'fortes', '002', 'fortes@hotmail.es', 1161595482, 1, 1, 1, 1, 1,1, '15/07/2018'
go
---------------------------- procedure------------------------------------------------------------------------------------

create procedure MateriaModificacionNombre
(@ID varchar(40), @Name varchar(100))

as
update Materias
set 
NombreMateria = @Name

where CodMateria = @ID 
return 
go

----------------------------------------------------------------------------------------------------------------
create procedure MateriaModificacionPrecio
(@ID varchar(40), @Monto money)

as
update Materias
set 
Monto = @Monto

where CodMateria = @ID 
return 
go

----------------------------------------------------------------------------------------------------------------

go
create procedure VerificarUsuario 
@user varchar(20), @contra varchar(20), @acceso int
as
select sum (acceso)
from Usuarios
where usuario=@user and contrasena = @contra
go
--------------------------------------------------------------------------------------------
create procedure EliminarUsuario
@user varchar(20), @contra varchar(20),@acceso int

AS
    DELETE FROM USUARIOS
    WHERE Usuario=@user
    RETURN
    
go
--------------------------------------------------------------------------------------------
create procedure ActualizarUsuario
(@user varchar(20), @contra varchar(20),@acceso int,@baja int )
as
update Usuarios 
set 
contrasena =@contra,
acceso =@acceso,
baja = @baja
where usuario =@user
return 
go
--------------------------------------------------------------------------------------------
create procedure UsuarioCambioContra
(@user varchar(20), @contra varchar(20),@acceso int )

as
update Usuarios 
set 
contrasena =@contra
where usuario =@user
return 
go
--------------------------------------------------------------------------------------------
create procedure UsuarioEnuso
@user varchar(20)
as
select COUNT (usuario)
from Usuarios
where usuario=@user


--------------------------------------------------------------------------------------------
go
create procedure CrearUsuario
@user varchar(20), @contra int , @acceso int
as
insert into Usuarios(usuario,contrasena,acceso)
select @user,@contra, @acceso 

select count (usuario)
from usuarios
where usuario =@user
--------------------------------------------------------------------------------------------
go
create procedure EliminarInscripto (
@DNI int 
)
AS
    DELETE FROM Inscriptos
    WHERE DNI=@DNI
    RETURN

go
--------------------------------------------------------------------------------------------
go
create procedure VerificarUsuarioActivo (
@user varchar(20), @contra int 
)
AS
declare @ar int
set @ar = 4 

if ((select COUNT(usuario)from Usuarios where usuario= @user)>0) begin
		if((select COUNT(usuario)from Usuarios where usuario= @user and baja=0)>0)
					begin		
					if((select COUNT(usuario)from Usuarios where usuario= @user and contrasena=@contra)>0) begin set @ar=1 end
					else begin set @ar=-2 end
					end
		else begin set @ar=-3 end

end
else begin set @ar=-1 end

select @ar
-- muestra -3 = USUARIO DADO DE BAJA
-- muestra -2 = CONTRASENA MAL
-- muestra -1 = USUARIO NO EXISTE
-- muestra	1 = USUARIO Y CONTRASENA Y NO DADO DE BAJA PERFECTO.
  go
  
--------------------------------------------------------------------------------------------
--drop procedure VerificarMateria
--go
create procedure VerificarMateria (
@Name varchar(100) 
)
AS
declare @ar int
set @ar = 4 

if ((select COUNT(NombreMateria)from Materias where NombreMateria = @Name)>0) 
begin set @ar=-1
end
else begin set @ar=1 end

select @ar
  go  
  -- muestra -1 = NOMBRE MATERIA NO EXISTE
  -- muestra 1 = CASO CONTRARIO 

--------------------------------------------------------------------------------------------
--drop procedure CrearMateria
--go
create procedure CrearMateria(
@ID varchar(40), @Name varchar(100), @Monto money)

as
insert into Materias(CodMateria,NombreMateria,Monto)
select @ID,@Name,@Monto

go
--------------------------------------------------------------------------------------------
create procedure CargaPreinscripto (
 @DNI int,@codcurso varchar(40),@IDinscripto int,@Nombre varchar(50),@Apellido varchar(50),
              @Email varchar(100),@Telefono varchar(30),@DNIOLD int,@Turno varchar(60),@Modalidad varchar(60),
              @usuarioactivo varchar(20))
as


insert into Preinscriptos (DNI,codcurso,IDinscripto,Nombre,Apellido,Email,Telefono,DNIOLD,Turno,Modalidad,Usuario)
select @DNI,@codcurso,@IDinscripto,@Nombre,@Apellido,@Email,@Telefono,@DNIOLD,@Turno,@Modalidad, @usuarioactivo

go
--------------------------------------------------------------------------------------------


--select * 
----from Cursos
--DELETE Especialidades
--WHERE Codespecialidad = '006'

--exec MateriaModificacionPrecio '003',500
--go




--select *
--from Materias

--where CodMateria LIKE '%3%'

