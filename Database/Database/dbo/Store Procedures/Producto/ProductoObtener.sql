CREATE PROCEDURE [dbo].[ProductoObtener]
	@IdProducto int=NULL
AS BEGIN
SET NOCOUNT ON
	SELECT
		P.IdProducto,
		C.IdCategoria,
		P.Nombre,
		P.Cantidad,
		P.Caracteristicas,
		P.Estado
	FROM dbo.Producto P, Categoria C
	WHERE
		(@IdProducto IS NULL OR IdProducto=@IdProducto)
END
GO
