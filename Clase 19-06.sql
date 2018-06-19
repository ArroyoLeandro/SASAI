--- INFORMATION_SCHEMA----
Select * from INFORMATION_SCHEMA.TABLES -- muestras todas las tablas qe tiene la bd
Select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS - todas las restricciones que tiene la bd
--- FIN INFORMATION_SCHEMA----

create database tes
go
use tes
go
DECLARE @Number int 
SET @Number = 150

if @Number < 100
PRINT 'El numero es grande'
else 
BEGIN 
if @Number <10
PRINT 'El numero es chico'-- Imprime el texto en pantalla
ELSE
Select 'El numero es mediano' as RESULTADO  -- muestra el texto dentro de una grilla
END
GO




--hace basicamente lo mismo que el switch
SELECT Nom_pruebas, cant_pruebas AS Name FROM PRUEBAS
GO
--fin---

--- SWITCH----
SELECT nombre_Prueba 
[mayor o menor?] =  -- CORCHETES POR EL ESPACIO.
CASE 
	When cant_Prueba <40 then 'Menor' -- CUANDO... // CASE1 
	When cant_Prueba >70 then 'MEDIO' -- CUANDO ... /// CASE2
	Else 'Mayor' -- DEFAULT
END

from pruebas
go
--- SWITCH ----




--- if exists----
if exists (select * from articulos where cantidad = 0) -- tambien hay un not exists que hace lo contrario
(select articulos from articulos where cantidad = 0)
else
	select 'hay stock en todos los articulos' as mensaje
	-- o: print 'hay stock en todos los articulos'
--- if exists----	
	
	--- if not exists----
	IF not exists (select * from INFORMATION_SCHEMA.TABLES where
TABLE_NAME='ssx')
begin
create table ssx
(
ssx_id int identity(1,1) primary key,
ssx_desc varchar(40) not null
)
End

--- if not exists----



-- SWITCH MAS GRANDE ---
USE Clase09
GO
SELECT CodArticulo, Articulo, 'Rango de Precios' =
CASE
WHEN PrecioUnitario < 50 THEN 'Menos de $50'
WHEN PrecioUnitario >= 50 and PrecioUnitario < 250 THEN 'Menos de $250'
WHEN PrecioUnitario >= 250 and PrecioUnitario < 1000 THEN 'Menos de $1000'
ELSE 'Más de $1000'
END
FROM Articulos
ORDER BY CodArticulo
GO
---SWITCH-- 




-- FUNCIONES -- 

--NUMERICAS

abs(x): retorna el valor absoluto del argumento "x". Ejemplo:
select abs(-20);
retorna 20.
ceiling(x): redondea hacia arriba el argumento "x". Ejemplo:
select ceiling(12.34);
retorna 13.
floor(x): redondea hacia abajo el argumento "x". Ejemplo:
select floor(12.34);
retorna 12.
%: devuelve el resto de una división. Ejemplos:
select 10%3;
retorna 1.
select 10%2;
retorna 0.
power(x,y): retorna el valor de "x" elevado a la "y" potencia. Ejemplo:
select power(2,3);
retorna 8.
round(numero,longitud): retorna un número redondeado a la longitud
especificada. "longitud" debe ser tinyint, smallint o int. Si "longitud" es
positivo, el número de decimales es redondeado según "longitud"; si es
negativo, el número es redondeado desde la parte entera según el valor de
"longitud". Ejemplos:
select round(123.456,1);
retorna "123.400", es decir, redondea desde el primer decimal.
select round(123.456,2);
retorna "123.460", es decir, redondea desde el segundo decimal.
EJERCICOS SQL 4 de 7
select round(123.456,-1);
retorna "120.000", es decir, redondea desde el primer valor entero (hacia la
izquierda).
select round(123.456,-2);
retorna "100.000", es decir, redondea desde el segundo valor entero (hacia la
izquierda).
sign(x): si el argumento es un valor positivo devuelve 1;-1 si es negativo y si
es 0, 0.

square(x) retorna el cuadrado del argumento. Ejemplo:
select square(3); --retorna 9.
sqrt(x): devuelve la raiz cuadrada del valor enviado como argumento.
--SQL Server dispone de funciones trigonométricas que retornan radianes.
--Se pueden emplear estas funciones enviando como argumento el nombre de
--un campo de tipo numérico.

--FIN NUMERICAS


-- CARACTERES


ascii (character_expression): Devuelve el valor del código ASCII del
carácter más a la izquierda de una expresión de caracteres.
select ASCII('Ariel');
retorna 65.
select ASCII('A');
retorna 65.
select ASCII('a');
retorna 97.
cast (integer_expression): Convierte un número int en caracteres
numéricos.
select CAST(65 as varchar(4));
retorna '65'
char (integer_expression): Convierte un código ASCII int en un caracter.
select CHAR(65);
retorna 'A'.


EJERCICOS SQL 5 de 7
left (character_expression, integer_expression): Devuelve la parte
izquierda de una cadena de caracteres con el número de caracteres
especificado.
select LEFT('Articulo', 2)
retorna 'Ar'.
select LEFT(Articulo, 2)from Articulos
retorna las primeras dos letras del contenido de la columna Articulo en la tabla
Articulos.
len (string_expression): Devuelve el número de caracteres de la expresión
de cadena especificada, excluidos los espacios en blanco finales.
select LEN('Articulo')
retorna 8.
select LEN(Articulo) from Articulos
retorna las diferentes longitudes del contenido de la columna Articulo en la
tabla Articulos, teniendo en cuenta que el tipo de dato corresponde a una
cadena de longitud variable.
lower(character_expression): Devuelve una expresión de caracteres
después de convertir en minúsculas los datos de caracteres en mayúsculas.
select LOWER('Articulo')
retorna ‘articulo’.
upper(character_expression): Devuelve una expresión de caracteres
después de convertir en mayúsculas los datos de caracteres en minúsculas.
select UPPER('Articulo') 
retorna ‘’ARTICULO’.
right (character_expression, integer_expression): Devuelve la parte
derecha de una cadena de caracteres con el número de caracteres
especificado.
select RIGHT('Articulo', 2)
retorna ‘lo’.
select RIGHT(Articulo, 2) from Articulos
retorna las primeras últimas letras del contenido de la columna Articulo en la
tabla Articulos.


--FIN CARACTERES



--FECHA Y HORA

getdate(): retorna la fecha y hora actuales. Ejemplo:
select getdate(); --- LO QUE MAS VAMOS A USAR





datepart(partedefecha,fecha): retorna la parte específica de una fecha, el
año, trimestre, día, hora, etc.
Los valores para "partedefecha" pueden ser: year (año), quarter (cuarto),
month (mes), day (dia), week (semana), hour (hora), minute (minuto),
second (segundo) y millisecond (milisegundo). Ejemplos:

select datepart(month,getdate());
retorna el número de mes actual;
select datepart(day,getdate());
retorna el día actual;
select datepart(hour,getdate());
retorna la hora actual;
datename(partedefecha,fecha): retorna el nombre de una parte específica
de una fecha. Los valores para "partedefecha" pueden ser los mismos que se
explicaron anteriormente. Ejemplos:
select datename(month,getdate());
retorna el nombre del mes actual;


select datename(dw,getdate()); -- NOS DICE QUE DIA ES HOY


dateadd(partedelafecha,numero,fecha): agrega un intervalo a la fecha
especificada, es decir, retorna una fecha adicionando a la fecha enviada como
tercer argumento, el intervalo de tiempo indicado por el primer parámetro,
tantas veces como lo indica el segundo parámetro. Los valores para el primer
argumento pueden ser: year (año), quarter (cuarto), month (mes), day (dia),
week (semana), hour (hora), minute (minuto), second (segundo) y millisecond
(milisegundo). Ejemplos:
select dateadd(day,3,'1980/11/02');
retorna "1980/11/02", agrega 3 días.
select dateadd(month,3,'1980/11/02');
retorna "1980/05/11", agrega 3 meses.

SELECT DATEADD(MONTH,3,GETDATE()); -- muestra la fecha actual mas 3 meses

EJERCICOS SQL 7 de 7
select dateadd(hour,2,'1980/11/02');
retorna "1980/02/02 2:00:00", agrega 2 horas.
select dateadd(minute,16,'1980/11/02');
retorna "1980/02/02 00:16:00", agrega 16 minutos.
datediff(partedelafecha,fecha1,fecha2): calcula el intervalo de tiempo
--(según el primer argumento) entre las 2 fechas. El resultado es un valor
--entero que corresponde a fecha2-fecha1. Los valores de "partedelafecha)
--pueden ser los mismos que se especificaron anteriormente. Ejemplos:
--select datediff (day,'2005/10/28','2006/10/28');
--retorna 365 (días).
--select datediff(month,'2005/10/28','2006/11/29');
--retorna 13 (meses).
--day(fecha): retorna el día de la fecha especificada. Ejemplo:
--select day(getdate());
--month(fecha): retorna el mes de la fecha especificada. Ejemplo:
--select month(getdate());
--year(fecha): retorna el año de la fecha especificada. Ejemplo:
--select year(getdate());
--Se pueden emplear estas funciones enviando como argumento el nombre de
--un campo de tipo datetime o smalldatetime.

--FIN FECHA Y HORA




--  FIN FUNCIONES

--Ejercicio 6.3

create table Art (
stock varchar(100)  not null,
nombre varchar(50)  not null,
descripcion varchar(50)  not null,
FechaReg date not null
)

drop table pedidos

if not exists (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'pedidos') -- tambien hay un not exists que hace lo contrario

begin	
create table pedidos (
cantidad int not null,
articulo varchar(50)  not null,
descripcion varchar(50)  not null,
FechaReg date not null
)

end
go


create table proveedores (
stock varchar(100)  not null,
Nombre varchar(50)  not null,
Email varchar(50)  not null,
RazonSocial varchar(50) not null

)

go

create procedure CREAR_PEDIDO(
@cantidad int, @arti varchar(50),@desc varchar(50)
)
AS
    INSERT INTO pedidos(cantidad,articulo,descripcion,FechaReg)
	select @cantidad,@arti, @desc, FechaReg=getdate()
    
go


exec CREAR_PEDIDO  100,'papa','comida pa el body'



alter table Art add PuntoPedido int;



select upper(descripcion), LOWER(articulo), cantidad from pedidos 




select * from Art



-- TREIGGER SIRVE PARA EJECUTAR ALGO AUTOMATICAMENTE---  AL EJECUTAR UNA ACTUALIZACION SE EJECUTA ESTE TRIGGER
CREATE TRIGGER TR_Name  -- NOMBRE ASIGANDO POR MI
ON pedidos -- EN QUE TABLA SE VA A GUARDAR
AFTER UPDATE -- CUANDO HAY UNA ACTUALIZACION
AS
BEGIN
-- SET NOCOUNT ON impide que se
--generen mensajes de texto
-- con cada instrucción
SET NOCOUNT ON;
INSERT INTO pedidos --TABLA DONDE INSERTAR
(cantidad, arti, FechaReg)
SELECT cantidad,arti, getdate() 
--EJERCICOS SQL 3 de 6
FROM INSERTED  -- PARA INSERTAR LO DEL SELECT
END
--FIN TRIGGER



-- UPDATE DE UNA TABLA PARA EJECUTAR EL TRIGGER--

update pedidos
set cantidad = 200
where articulo = 'papa'

---FIN UPDATE


---TRIGGER CON ROLLBACK // QUE SIRVE PARA COMO UNA EXCEPTION 
-- por ejemplo que actualice el stock cada vez que vende, pero si llega  negativo que haga el rollback para que 
--	no se genere la venta porque no deberia poderse vender algo que no tenemos

ALTER TRIGGER NombreCualquiera
ON TablaDondeGuarda
AFTER UPDATE
AS
BEGIN
-- SET NOCOUNT ON impide que se
--generen mensajes de texto
-- con cada instrucción
SET NOCOUNT ON;
INSERT INTO TablaDondeInserto
(Dato1, Dato2, Dato3)
SELECT Dato1, Dato2, Dato3
FROM INSERTED  
ROLLBACK
END
-- Fin de TRIGGER ROLLBACK


--DESACTIVAR EL TRIGGER

DISABLE TRIGGER NombreCualquiera ON TablaDondeGuarda
GO
--FIN DESACTIVAR TRIGGER

-- La siguiente instrucción impide que se ejecuten sentencias DROP TABLE y ALTER TABLE en la base de datos.

CREATE TRIGGER TR_SEGURIDAD
ON DATABASE FOR DROP_TABLE,
ALTER_TABLE
AS
BEGIN
RAISERROR ('No está permitido borrar ni modificar tablas !' , 16, 1)
ROLLBACK TRANSACTION -- INTENTA Y TIRA EL MENSAJE QUE NO SE PUEDE BORRAR // ROLLBACK TRANSACTION ES IGUAL A ROLLBACK 
END

--FIN TRIGGER SEGURIDAD





--Para parcial 2
--funciones basicas de fecha, getdate();
--check, default,etc. Deberian estar validados antes de la base de datos

