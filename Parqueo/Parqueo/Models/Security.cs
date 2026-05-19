using System.Security.Cryptography;
using System.Text;
using System;

namespace Parqueo.Utilidades
{
    public static class Seguridad
    {
        // Método para generar el hash SHA256 de una contraseña
        public static string HashContrasena(string contrasena)
        {
            // Usamos la clase SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // 1. Convertir la cadena de entrada (contraseña) a bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contrasena));

                // 2. Convertir el array de bytes resultante a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    // "x2" formatea el byte como dos caracteres hexadecimales
                    builder.Append(bytes[i].ToString("x2"));
                }
                // El resultado es el hash de la contraseña
                return builder.ToString();
            }
        }
    }
}