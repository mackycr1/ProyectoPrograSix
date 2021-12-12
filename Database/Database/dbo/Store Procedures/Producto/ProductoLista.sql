CREATE PROCEDURE [dbo].[ProductoLista]
	AS 

BEGIN

	SET NOCOUNT ON

	SELECT  IdProducto
			,IdCategoria
			,Nombre
			,Cantidad
			,Caracteristicas
			,Precio
			,Estado
	FROM [dbo].[Producto]
	
END
