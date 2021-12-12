CREATE TABLE [dbo].[Producto]
(
	[IdProducto]  INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_ProductoId PRIMARY KEY CLUSTERED([IdProducto]),
    [IdCategoria] INT NOT NULL CONSTRAINT FK_CategoriaId FOREIGN KEY([IdCategoria]),
    [Nombre] VARCHAR(250) NOT NULL,
    [Cantidad] INT NOT NULL, 
    [Caracteristicas] VARCHAR(250) NOT NULL,
    [Estado] BIT NOT NULL
) WITH (DATA_COMPRESSION = PAGE)
GO
