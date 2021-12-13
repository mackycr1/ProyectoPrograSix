CREATE PROCEDURE [dbo].[CategoriaObtener]
	@IdCategoria int = null
AS BEGIN
  SET NOCOUNT ON

	SELECT 
		IdCategoria,
		NombreCategoria
	FROM dbo.Categoria WHERE IdCategoria=@IdCategoria

END