﻿CREATE PROCEDURE [dbo].[ProductoInsertar]      
	@IdCategoria INT,
	@Nombre VARCHAR(250),
	@Cantidad INT,
	@Caracteristicas VARCHAR(250),
	@Estado BIT

AS BEGIN
  
	SET NOCOUNT ON

	BEGIN TRANSACTION TRANS
	
		BEGIN TRY 
			
			INSERT INTO [dbo].[Producto]
			(
				 IdCategoria
				,Nombre
				,Cantidad
				,Caracteristicas
				,Estado
			)
			VALUES
			(
				 @IdCategoria
				,@Nombre
				,@Cantidad
				,@Caracteristicas
				,@Estado
			)
			
			COMMIT TRANSACTION TRANS
			SELECT 0 AS CodeError, '' AS MsgError

		END TRY

		BEGIN CATCH
			
			SELECT   ERROR_NUMBER() AS CodeError
					,ERROR_MESSAGE() AS MsgError
		
			ROLLBACK TRANSACTION TRANS

		END CATCH
END
GO
