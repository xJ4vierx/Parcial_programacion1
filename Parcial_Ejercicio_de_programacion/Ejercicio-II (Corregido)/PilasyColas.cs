using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II
{
    class Program
    {
        static void Main()
        {
            Stack<int> pila = new Stack<int>();
            Queue<string> cola = new Queue<string>();

            if (pila.Count > 0)
            {
                int valorPila = pila.Pop();
                Console.WriteLine("Valor sacado de la pila: " + valorPila);
            }
            else
            {
                Console.WriteLine("La pila está vacía, no se puede hacer Pop().");
            }

            if (cola.Count > 0)
            {
                string primerElemento = cola.Dequeue();
                Console.WriteLine("Elemento eliminado de la cola: " + primerElemento);
            }
            else
            {
                Console.WriteLine("La cola está vacía, no se puede hacer Dequeue().");
            }
        }
    }
}
