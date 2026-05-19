-- 1. Renombrar la columna 'Contrasena' a 'ContrasenaHash'
-- Esto lo hacemos para que el nombre de la columna refleje que guarda un hash seguro
EXEC sp_rename 'Usuario.Contrasena', 'ContrasenaHash', 'COLUMN';
GO

-- 2. Ajustar el tamaño a NVARCHAR(64)
-- Esto es crucial para que quepan los 64 caracteres del hash SHA256.
ALTER TABLE Usuario
ALTER COLUMN ContrasenaHash NVARCHAR(64) NOT NULL;
GO

PRINT 'Tabla Usuario modificada exitosamente. Columna renombrada y ajustada a NVARCHAR(64).';