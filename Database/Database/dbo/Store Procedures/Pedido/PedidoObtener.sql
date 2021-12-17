CREATE PROCEDURE [dbo].[PedidoObtener]

	@IdPedido INT = NULL

AS BEGIN

	SET NOCOUNT ON
	
	SELECT	PE.IdPedido,
			PE.IdCliente,
			C.IdCliente,
			C.NombreCliente,
			C.PrimerAPEllidoCliente,
			C.SegundoAPEllidoCliente,
			C.TelefonoCliente,
			PE.Codigo,
			PE.Fecha,
			PE.Envio,
			PE.SubTotal,
			PE.IVA,
			PE.Total
	FROM [dbo].[Pedido] PE
	LEFT JOIN dbo.Cliente C
	ON PE.IdCliente = C.IdCliente
	WHERE (@IdPedido IS NULL OR IdPedido = @IdPedido)
END
GO
