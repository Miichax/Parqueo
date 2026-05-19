CREATE PROCEDURE spIniciarSesion
    @pNombreUsuario NVARCHAR(50),
    @pContrasena NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IdUsuario,
        NombreUsuario,
        NombreCompleto,
        Rol
    FROM Usuarios
    WHERE NombreUsuario = @pNombreUsuario
      AND ContrasenaHash = @pContrasena;
END