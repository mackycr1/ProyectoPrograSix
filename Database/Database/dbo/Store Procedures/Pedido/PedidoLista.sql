CREATE PROCEDURE [dbo].[PedidoLista]
	AS 

BEGIN

	SET NOCOUNT ON

	SELECT IdPedido
				,Cliente
				,Fecha
				,IdProducto
				,Cantidad
				,PrecioUnitario
				,Envio
				,SubTotal
				,IVA
				,Total
	FROM [dbo].[Pedido]
	
END
