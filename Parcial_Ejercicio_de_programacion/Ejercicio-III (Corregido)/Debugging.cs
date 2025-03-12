using System;
using System.Diagnostics; 

namespace Ejercicios
{
    class Debugging
    {
        static void Main()
        {
            try
            {
                int a = 10;
                int b = 0;

                Debug.WriteLine($"Valor de a: {a}");
                Debug.WriteLine($"Valor de b: {b}");

                if (b != 0)
                {
                    int resultado = a / b; 
                    Console.WriteLine($"Resultado: {resultado}");
                    Debug.WriteLine($"Resultado de la división: {resultado}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    Debug.WriteLine("Intento de división entre cero evitado.");
                }

                int suma = a + 5 * 2;  
                Console.WriteLine($"Suma corregida: {suma}");
                Debug.WriteLine($"Suma corregida: {suma}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                Debug.WriteLine($"Excepción capturada: {ex.Message}");
            }
        }
    }
}
