CREATE PROCEDURE [dbo].[PedidoObtener]
	@IdPedido int=NULL
AS BEGIN
SET NOCOUNT ON
	SELECT
				pe.IdPedido,
				pe.IdCliente,
				pe.IdProducto,
				pe.Fecha,
				pe.IdProducto,
				pe.Cantidad,
				pe.PrecioUnitario,
				pe.Envio,
				pe.SubTotal,
				pe.IVA,
				pe.Total,
				P.Nombre,
				C.NombreCliente,
				C.PrimerApellidoCliente,
				C.SegundoApellidoCliente,
				C.TelefonoCliente
	FROM dbo.Pedido pe
	LEFT JOIN dbo.Producto P
	ON pe.IdPedido= P.IdProducto
	LEFT JOIN dbo.Cliente C
	ON pe.IdCliente= C.IdCliente
	WHERE
		(@IdPedido IS NULL OR IdPedido=@IdPedido)
END
GO
