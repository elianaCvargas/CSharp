select (recetaID , nombre, preparacion ) from  Recetas
select * from RecetaIngrediente
select nombre from Recetas

--delete from RecetaIngrediente where nombre like 'sad';
delete RecetaIngrediente from Recetas inner join RecetaIngrediente on Recetas.recetaID = RecetaIngrediente.recetaID where  Recetas.recetaID = 9;
--delete Proveedor from Proveedores as Proveedor where not exists(select  * from Proveedores inner join Envio on Envio.Numero = Proveedor.Numero)