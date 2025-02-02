using System;

class Program
{
    // Variable global para almacenar la suma total
    static int sumaTotal = 0;

    // Función para agregar un número a la suma total
    static void AgregarNumero(int numero)
    {
        sumaTotal += numero; // Sumar el número a la variable global
    }

    static void Main()
    {
        Console.WriteLine("Programa para sumar una serie de números enteros.");
        Console.WriteLine("Escribe números enteros. Escribe '0' para terminar.");

        int numero;
        do
        {
            Console.Write("Ingresa un número: ");
            numero = int.Parse(Console.ReadLine()); // Leer el número ingresado por el usuario

            if (numero != 0) // Si no es 0, agregarlo a la suma
            {
                AgregarNumero(numero);
            }
        } while (numero != 0); // Repetir hasta que el usuario ingrese 0

        Console.WriteLine($"La suma total es: {sumaTotal}");
    }
}
