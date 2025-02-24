using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularnumero
{
    interface Operacion
    {
        double Sumar(double num1, double num2);
        double Restar(double num1, double num2);
        double Multiplicar(double num1, double num2);
        double Dividir(double num1, double num2);
        double Modulo(double num1, double num2); // Nuevo método para obtener el módulo
    }
}