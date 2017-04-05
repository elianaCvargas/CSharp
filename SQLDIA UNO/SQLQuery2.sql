--insert  into Persona(Nombre, Apellido, Edad) values ('Ivan', 'Pillud', 20), ('Liandro', 'Lopoez', 33), ('Luciano', 'Auedo', 30);

/* select * from persona;
 select nombre from persona;
 select * from Persona where Nombre = 'ivan';
 select * from Persona where Nombre = 'Luciano';

 update Persona set Apellido  ='De pineda' where Apellido = 'Pillud';
 
 select * from Persona where Nombre = 'Ivan';
 delete from Persona where Apellido = 'Lopoez';
 select * from Persona;

 select * from Persona where Apellido like '%d%';
 select * from Persona where Apellido like '___d%';
 select MIN(Edad) as Edad_min,  MAX(Edad) as Edad_max from Persona;*/

 select * from Persona inner join Esclavo on Persona.Edad = Esclavo.Edad ;