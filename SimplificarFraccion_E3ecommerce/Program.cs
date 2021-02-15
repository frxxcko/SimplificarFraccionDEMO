using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplificarFraccion_E3ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafío E3ecommerce Simplifación de Fracciones. Desarrollador: Juan Ignacio Basualdo.");
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese la fracción a simplificar. Por ejemplo: 5/15");
            string cadena = Console.ReadLine();
            Fracciones fraccion = new Fracciones();
            fraccion.validar(cadena);
            Console.ReadLine();
        }
    }
}
