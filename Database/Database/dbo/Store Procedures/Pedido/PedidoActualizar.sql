﻿CREATE PROCEDURE [dbo].[PedidoActualizar]
	@IdPedido INT,
	@IdCliente INT,
	@Codigo NVARCHAR(200),
	@Fecha datetime,
	@Envio INT,
	@SubTotal INT,
	@IVA decimal(18,2),
	@Total decimal(18,2) 
	
AS BEGIN

	SET NOCOUNT ON
	BEGIN TRANSACTION TRANS
		BEGIN TRY 
			
			UPDATE [dbo].[Pedido]
			SET  IdCliente = @IdCliente
				,Codigo = @Codigo
				,Fecha = @Fecha
				,Envio = @Envio
				,SubTotal = @SubTotal
				,IVA = @IVA
				,Total = @Total
			WHERE IdPedido = @IdPedido
			
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


