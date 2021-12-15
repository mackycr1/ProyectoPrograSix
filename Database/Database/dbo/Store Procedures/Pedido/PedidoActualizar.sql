CREATE PROCEDURE [dbo].[PedidoActualizar]
	@IdPedido INT,
	@Cliente VARCHAR(50),
	@Fecha datetime,
	@IdProducto INT,
	@Cantidad INT,
	@PrecioUnitario INT,
	@Envio INT,
	@SubTotal INT,
	@IVA decimal(18,2),
	@Total decimal(18,2) 
	
AS BEGIN

	SET NOCOUNT ON
	BEGIN TRANSACTION TRANS
		BEGIN TRY 
			
			UPDATE [dbo].[Pedido]
			SET  IdProducto=@IdProducto
				,Cliente=@Cliente
				,Fecha=@Fecha
				,IdProducto=@IdProducto
				,Cantidad=@Cantidad
				,PrecioUnitario=@PrecioUnitario
				,Envio=@Envio
				,SubTotal=@SubTotal
				,IVA=@IVA
				,Total=Total

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


