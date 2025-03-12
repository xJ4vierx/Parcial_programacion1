using System;
using System.Data.SqlClient;
using System.Diagnostics;  

namespace Ejercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=Escuela;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                Debug.WriteLine("Conexión abierta correctamente.");
                Console.WriteLine("Conexión abierta correctamente.");

                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la edad del estudiante: ");
                int edad = int.Parse(Console.ReadLine());

                string query = "INSERT INTO Estudiantes (Nombre, Edad) VALUES (@nombre, @edad)";
                Debug.WriteLine("Consulta SQL: " + query);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@edad", edad);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    Console.WriteLine("Filas insertadas: " + filasAfectadas);
                    Debug.WriteLine("Filas insertadas: " + filasAfectadas);
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error de SQL: " + sqlEx.Message);
                Debug.WriteLine("Error de SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Debug.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada.");
                    Debug.WriteLine("Conexión cerrada.");
                }
            }
        }
    }
}

