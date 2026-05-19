USE ParqueoDB;
GO

-- ¡PEGA EL HASH COPIADO AQUÍ!
DECLARE @hash_actual NVARCHAR(64) = '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'; 

UPDATE dbo.Usuarios -- Usa el nombre de tu tabla (Usuarios o Usuario)
SET ContrasenaHash = @hash_actual 
WHERE NombreUsuario = 'micha'; -- Usa el nombre de usuario de tu prueba
GO

-- Verifica que se actualizó (deberías ver el hash largo)
SELECT NombreUsuario, ContrasenaHash FROM dbo.Usuarios WHERE NombreUsuario = 'micha';