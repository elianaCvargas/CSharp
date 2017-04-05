--select * from Envio, Productos, Proveedores;
select pNumero as hjgj, pNombre as gfdfsdgf from Productos;
select * from Envio;
select * from Proveedores;

select * from Productos  order by pNombre asc;
--. Obtener los detalles completos de todos los proveedores de ‘Capital’.
select * from Proveedores where Localidad like 'Capital'
--. Obtener todos los envíos en los cuales la cantidad esta entre 200 y 300 inclusive.
select * from Envio where cantidad between 200 and 300
--Obtener la cantidad total de todos los productos enviados.
select SUM(Cantidad) from Envio;
--. Mostrar el promedio de precio de la tabla Productos.
select AVG(Precio) from Productos
--. Indicar el monto (cantidad * precio) de todos los enviados.
select Cantidad*Precio from Envio inner join Productos on Envio.pNumero = Productos.pNumero
--Obtener la cantidad total del producto 1 enviado por el proveedor 102.
select Sum(Cantidad) from Envio  where pNumero = 1;
--Obtener todos los números de los productos suministrados por algún proveedor de ‘Avellaneda’.(101)
select pNumero as Producto from Envio inner join Proveedores on Envio.Numero = Proveedores.Numero where Localidad like 'Avellaneda';
--Obtener el domicilio y localidades de los proveedores cuyos nombres contengan la letra ‘I’
select Domicilio from Proveedores where Localidad like '%I%'
--Agregar el producto número 4, llamado ‘Chocolate’, de tamaño chico y con un precio de 0,35.
--insert into Productos (pNumero, pNombre, Precio, Tamaño) values(, 'Chocolate', 0.35, 'Chico')
-- Insertar un nuevo proveedor (únicamente los campos obligatorios).
-- Insertar un nuevo proveedor (107), donde el nombre y la localidad sean ‘Rosales’ y ‘La Plata’.
--Cambiar los precios de los productos de tamaño ‘grande’ a 7,50.
--14. Cambiar el tamaño de ‘chico’ a ‘mediano’ de todos los productos cuyas cantidades sean mayores a 300 inclusive.
update Productos set Tamaño = 'Mediano' from Productos inner join Envio on    Envio.pNumero  = Productos.pNumero where Cantidad > 300
--Eliminar el producto número 1.(izi)

--16. Eliminar a todos los proveedores que no han enviado productos.
--select Nombre  from  Proveedores inner join Envio on Proveedores.Numero = Envio.Numero where

delete Proveedor from Proveedores as Proveedor where not exists(select  * from Proveedores inner join Envio on Envio.Numero = Proveedor.Numero)