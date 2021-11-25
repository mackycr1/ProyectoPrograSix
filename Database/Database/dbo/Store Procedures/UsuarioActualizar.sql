CREATE PROCEDURE [dbo].[UsuarioActualizar]
    @Usuario varchar(10),
	@NombreCompleto varchar(50),
	@Clave varchar(50),
	@Estado bit,
	@Rol_id int

AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE usuario SET
	 Nombre_Completo = @NombreCompleto,
	 Clave = @Clave,
	 Estado = @Estado,
	 Rol_id = @Rol_id
	WHERE 
	       Usuario = @Usuario;
	
	  COMMIT TRANSACTION TRASA
	  SELECT 0 AS CodeError, '' AS MsgError

  END TRY

  BEGIN CATCH

	   SELECT 
			 ERROR_NUMBER() AS CodeError,
			 ERROR_MESSAGE() AS MsgError
   
	   ROLLBACK TRANSACTION TRASA

   END CATCH

 END