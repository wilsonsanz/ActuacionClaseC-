using System;

class Program
{
    // Función para calcular el área de un círculo
    static double CalcularAreaCirculo(double radio)
    {
        const double PI = Math.PI; // Usamos el valor de PI proporcionado por .NET
        return PI * Math.Pow(radio, 2); // Fórmula: π × r²
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = double.Parse(Console.ReadLine());

        double area = CalcularAreaCirculo(radio);

        Console.WriteLine($"El área del círculo con radio {radio} es: {area:F2}");
    }
}
