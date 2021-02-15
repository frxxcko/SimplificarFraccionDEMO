using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplificarFraccion_E3ecommerce
{
    class Fracciones
    {
        public void validar(string fraccionCadena)
        {
            StringBuilder cadena = new StringBuilder(fraccionCadena);
            int longitud = cadena.Length;
            string num1 = "";
            string num2 = "";
            int contadorNumero = 1;

            for(int i = 0; i < longitud; i++)
            {
                if (cadena[i] == '/')
                {
                    contadorNumero++;
                    continue;
                }
                if(contadorNumero == 1)
                {
                    num1 = num1 + cadena[i];

                }
                else
                {
                    num2 = num2 + cadena[i];
                }
            }

            int numerador = Convert.ToInt32(num1);
            int denominador = Convert.ToInt32(num2);
            simplificar(numerador, denominador);

        }

        public int MCD(int a, int b)
        {
            int residuo = 0;
            int mcd = 0;

            if(a > b)
            {
                while (b != 0)
                {
                    residuo = a % b;
                    a = b;
                    b = residuo;
                }
                mcd = a;
            }

            if(a < b)
            {
                while (a != 0)
                {
                    residuo = b % a;
                    b = a;
                    a = residuo;
                }
                mcd = b;
            }
            return mcd;
        }

        public void simplificar(int numerador, int denominador)
        {
            int resultado = 0;
            int mcd = MCD(numerador, denominador);

            if (numerador == denominador)
            {
                resultado = 1;
            }
            else
            {
                numerador = numerador / mcd;
                denominador = denominador / mcd;
            }

            if(resultado == 1)
            {
                Console.WriteLine("El resultado es: {0}", resultado);
            }
            else
            {
                Console.WriteLine("El resultado es: {0}/{1}", numerador, denominador);
            }
        }
    }
}
