CREATE PROCEDURE [dbo].[PedidoObtener]
	@IdPedido int=NULL
AS BEGIN
SET NOCOUNT ON
	SELECT
				pe.IdPedido,
				pe.Cliente,
				pe.Fecha,
				pe.IdProducto,
				pe.Cantidad,
				pe.PrecioUnitario,
				pe.Envio,
				pe.SubTotal,
				pe.IVA,
				pe.Total,

		
		P.IdProducto,
		P.Nombre

	FROM dbo.Pedido pe
	LEFT JOIN dbo.Producto P
	ON pe.IdPedido= P.IdProducto
	WHERE
		(@IdPedido IS NULL OR IdPedido=@IdPedido)
END
GO
