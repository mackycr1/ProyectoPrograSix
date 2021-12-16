CREATE PROCEDURE [dbo].[PedidoObtener]
	@IdPedido int=NULL
AS BEGIN
SET NOCOUNT ON
	SELECT
				pe.IdPedido,
				pe.IdCliente,
				C.IdCliente,
				C.NombreCliente,
				C.PrimerApellidoCliente,
				C.SegundoApellidoCliente,
				C.TelefonoCliente,
				pe.IdProducto,
				pe.Fecha,
				pe.Cantidad,
				pe.PrecioUnitario,
				pe.Envio,
				pe.SubTotal,
				pe.IVA,
				pe.Total,
				P.Nombre
	FROM dbo.Pedido pe
	LEFT JOIN dbo.Producto P
	ON pe.IdProducto= P.IdProducto
	LEFT JOIN dbo.Cliente C
	ON pe.IdCliente= C.IdCliente
	WHERE
		(@IdPedido IS NULL OR IdPedido=@IdPedido)
END
GO
