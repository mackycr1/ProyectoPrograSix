CREATE PROCEDURE [dbo].[PedidoInsertar]      
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
			
			INSERT INTO [dbo].[Pedido]
			(
				IdPedido
				,Cliente
				,Fecha
				,IdProducto
				,Cantidad
				,PrecioUnitario
				,Envio
				,SubTotal
				,IVA
				,Total

	
			)
			VALUES
			(
				 @IdPedido
				,@Cliente
				,@Fecha
				,@IdProducto
				,@Cantidad
				,@PrecioUnitario
				,@Envio
				,@SubTotal
				,@IVA
				,@Total

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
