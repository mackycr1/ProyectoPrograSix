CREATE TABLE [dbo].[Usuario]
(
	[Usuario] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [Nombre_Completo] VARCHAR(50) NOT NULL, 
    [Clave] VARCHAR(50) NOT NULL, 
    [Estado] bit NOT NULL, 
    [Rol_id] INT NOT NULL CONSTRAINT FK_Usuario_Rol FOREIGN KEY(Rol_id) REFERENCES dbo.Rol(Rol_id)
)
