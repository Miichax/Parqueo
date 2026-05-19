USE ParqueoDB;
GO

-- Reemplaza el procedimiento almacenado
ALTER PROCEDURE spIniciarSesion
    @pNombreUsuario NVARCHAR(50),
    @pContrasena NVARCHAR(180) 
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        IdUsuario, 
        NombreUsuario, 
        Rol 
    FROM 
        dbo.Usuarios   -- ¡CORREGIDO: Usando el plural 'Usuarios'!
    WHERE 
        NombreUsuario = @pNombreUsuario 
        AND ContrasenaHash = @pContrasena;
END
GO
PRINT 'SP spIniciarSesion corregido y creado con la referencia dbo.Usuarios.';