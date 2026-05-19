using Parqueo.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // Necesario para MessageBox

namespace Parqueo
{
    // DAL: Data Access Layer (Capa de Acceso a Datos)
    public class UsuarioDAL
    {
        public Reply Autenticar(string nombreUsuario, string contrasenaHash)
        {
            Reply respuesta = new Reply();

            try
            {
                using (SqlConnection conexion = Conexion.vConexionSisUser)
                {
                    using (SqlCommand comando = new SqlCommand("spIniciarSesion", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // Parámetros del SP
                        comando.Parameters.Add("@pNombreUsuario", SqlDbType.NVarChar, 50).Value = nombreUsuario;
                        comando.Parameters.Add("@pContrasena", SqlDbType.NVarChar, 180).Value = contrasenaHash;

                        // Abrir conexión
                        if (conexion.State != ConnectionState.Open)
                        {
                            conexion.Open();
                        }

                        // Llenar DataTable con la información del usuario
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(dt);

                        // Validación de usuario
                        if (dt.Rows.Count > 0)
                        {
                            respuesta.Ok = true;
                            respuesta.Mensaje = "Inicio de sesión exitoso.";
                            respuesta.Data = dt;  // Se envía la información del usuario
                        }
                        else
                        {
                            respuesta.Ok = false;
                            respuesta.Mensaje = "Usuario o contraseña incorrectos.";
                            respuesta.Data = null;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                respuesta.Ok = false;
                respuesta.Mensaje = "Error SQL: " + ex.Message;
            }
            catch (Exception ex)
            {
                respuesta.Ok = false;
                respuesta.Mensaje = "Error general: " + ex.Message;
            }

            return respuesta;
        }
        // Dentro de UsuarioDAL.cs

        public Reply InsertarUsuario(Usuarios Usuarios)
        {
            Reply respuesta = new Reply();

            // Declaramos las variables localmente para que C# las reconozca.
            SqlCommand comando = null;

            try
            {
                // 1. Llama a la conexión usando la clase 'Conexion'
                Conexion.vConexionSisUser.Open();

                // 2. Usamos la variable local 'comando'
                comando = new SqlCommand();

                // 3. Llama a la conexión usando la clase 'Conexion'
                comando.Connection = Conexion.vConexionSisUser;

                comando.CommandText = "spCrearUsuario";
                comando.CommandType = CommandType.StoredProcedure;

                // 4. Corrección de seguridad: Tamaño del Hash (256)
                comando.Parameters.Add("@pNombreUsuario", SqlDbType.NVarChar, 50).Value = Usuarios.NombreUsuario;
                comando.Parameters.Add("@pContrasenaUsuario", SqlDbType.NVarChar, 256).Value = Usuarios.Contrasena;
                comando.Parameters.Add("@pRolUsuario", SqlDbType.Int).Value = Usuarios.Rol;

                int FilasAfectadas = comando.ExecuteNonQuery();

                if (FilasAfectadas > 0)
                {
                    respuesta.Ok = true;
                    respuesta.Mensaje = "Se ha insertado de manera exitosa";
                }
                else
                {
                    // 5. Corrección de lógica: Si no afecta filas, no es exitoso
                    respuesta.Ok = false;
                    respuesta.Mensaje = "Ha ocurrido error al insertar.";
                }
            }
            catch (Exception ex)
            {
                respuesta.Ok = false;
                respuesta.Mensaje = "Error en la Base de Datos: " + ex.Message;
            }
            finally
            {
                // 6. Corrección de estabilidad: Forzar el cierre de la conexión.
                if (Conexion.vConexionSisUser != null && Conexion.vConexionSisUser.State == ConnectionState.Open)
                {
                    Conexion.vConexionSisUser.Close();
                }
            }

            return respuesta;
        }

    }
}