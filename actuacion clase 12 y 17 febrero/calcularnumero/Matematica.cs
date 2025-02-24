using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularnumero
{
    class Matematica:Operacion
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        // Método para restar dos números
        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        // Método para multiplicar dos números
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        // Método para dividir dos números, manejando la división por cero
        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return double.NaN; // Devuelve un valor especial indicando error
            }
            return num1 / num2;
        }

        // Método para obtener el módulo, manejando división por cero
        public double Modulo(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede calcular el módulo con divisor cero.");
                return double.NaN;
            }
            return num1 % num2;
        }
    }
}