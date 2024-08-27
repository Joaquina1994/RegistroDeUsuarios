using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClase1.Clases;

namespace EjercicioClase1.Modelos
{
    public class Usuario
    {   
        public int IdPersona { get; set; }
        public string Nombre { get; set; }  
        public string Apellido { get; set; }
        public decimal Edad {  get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Email {  get; set; }
        public string? Telefono {  get; set; }
        public int IdRol {  get; set; }

        public List<Usuario> TraerUsuarios()
        {
            ConexionDataBase conexionDataBase = new ConexionDataBase();
            string conexion = conexionDataBase.ConnectionString();
            string consulta = "SELECT * FROM Personas";

            List<Usuario> personas = new List<Usuario>();

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario()
                                {                                    
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    Edad = reader.GetInt32(3),
                                    FechaDeNacimiento = reader.GetDateTime(4),
                                    Email = reader.GetString(5),
                                    Telefono = reader.GetString(6),
                                    IdRol = reader.GetInt32(7),
                                };
                                personas.Add(usuario);
                            }
                        }
                    }
                }
                return personas;

            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }


        }

        public Usuario TraerUsuarioPorId(int idPersona)
        {
            ConexionDataBase conexionDataBase = new ConexionDataBase();
            string conexion = conexionDataBase.ConnectionString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT IdPersona, Nombre, Apellido, Edad, FechaDeNacimiento, Email, Telefono, IdRol FROM Personas ");
            stringBuilder.Append("WHERE IdPersona = @idPersona;");
            string consulta = stringBuilder.ToString();

            Usuario persona = new Usuario();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idPersona", idPersona);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                persona.IdPersona = reader.GetInt32(0);
                                persona.Nombre = reader.GetString(1);
                                persona.Apellido = reader.GetString(2);
                                persona.Edad = reader.GetInt32(3);
                                persona.FechaDeNacimiento = reader.GetDateTime(4);
                                persona.Email = reader.GetString(5);
                                persona.Telefono = reader.GetString(6);
                                persona.IdRol = reader.GetInt32(7);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return persona;
        }

        public bool AltaDeUsuario(Usuario usuario)
        {
            ConexionDataBase conexionDataBase = new ConexionDataBase();
            string conexion = conexionDataBase.ConnectionString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("INSERT INTO Personas (Nombre, Apellido, Edad, FechaDeNacimiento, Email, Telefono, IdRol)");
            stringBuilder.Append("VALUES (@Nombre, @Apellido, @Edad, @FechaDeNacimiento, @Email, @Telefono, @IdRol)");
            string consulta = stringBuilder.ToString();

            bool existoso = false;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        sqlCommand.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        sqlCommand.Parameters.AddWithValue("@Edad", usuario.Edad);
                        sqlCommand.Parameters.AddWithValue("@FechaDeNacimiento", usuario.FechaDeNacimiento);
                        sqlCommand.Parameters.AddWithValue("@Email", usuario.Email);
                        sqlCommand.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        sqlCommand.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                existoso = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return existoso;

        }
    }
}
