﻿CREATE PROCEDURE [dbo].[PedidoProductoEliminar]
    
	@IdPedido INT

AS BEGIN
  
	SET NOCOUNT ON

		BEGIN TRANSACTION TRAS
		BEGIN TRY
			
			DELETE FROM [dbo].[Pedido]
			WHERE IdPedido = @IdPedido
			
			COMMIT TRANSACTION TRANS
			SELECT 0 AS CodeError, '' AS MsgError
		END TRY

		BEGIN CATCH
			SELECT
				ERROR_NUMBER() AS CodeError,
				ERROR_MESSAGE() AS MsgError
			ROLLBACK TRANSACTION TRASA
		END CATCH
END	
GO