CREATE PROCEDURE [dbo].[ProductoLista]
	AS 

BEGIN

	SET NOCOUNT ON

	SELECT  IdProducto
			,IdCategoria
			,Nombre
			,Cantidad
			,Caracteristicas
			,Estado
	FROM [dbo].[Producto]
	
END
