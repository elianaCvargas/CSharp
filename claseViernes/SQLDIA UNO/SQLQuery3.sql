



--select * from Empleados where Fecha_Nac = '19-9-1977';
--select * from  Empleados where Sueldo > 11000;
--select SUM(Sueldo) as Suma_sueldo from Empleados;
--select  Max(Sueldo) as S_Max from Empleados;
--select Nombre, Direccion, Telefonon   from Empleados where  Sueldo = (select MIN(Sueldo) from Empleados);
--select Nombre, FechaNacimiento from Empleados  where Nombre like 'Ro%'

--insert into Empleados (Nombre, Direccion, Telefonon, FechaNacimiento,Sueldo, Localidad) values ('Julio Perez', 'Calle falsa 123','011334567', '1988-04-12' , 8900 , 2);
--insert into Empleados (Nombre, Direccion, Telefonon, FechaNacimiento,Sueldo, Localidad) values ('Dante Gómez', 'Siempre viva 345','02224267765', '1986-03-18', null,  3);

 
--update Empleados set Sueldo = 20000 where FechaNacimiento between '01-09-1980' and '01-09-1990';
select * from Empleados;
select * from Localidades;
--delete from Empleados where Nombre = 'Lucia Pérez';
 --select * from Persona inner join Esclavo on Persona.Edad = Esclavo.Edad ;
--delete  from Empleados inner join Localidades on Empleados.Localidad = 3 ;

delete from Empleados where Sueldo =(select MIN(Sueldo) from Empleados);





