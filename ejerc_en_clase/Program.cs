// Importamos las librerías necesarias
using System;

// Definición de la clase principal
class Program
{
    // Método principal del programa
    static void Main()
    {
        int opcion; // Variable para almacenar la opción seleccionada por el usuario
        do
        {
            // Mostrar el menú de opciones
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Adivinar un número");
            Console.WriteLine("2. Validar edad");
            Console.WriteLine("3. Calificación");
            Console.WriteLine("4. Par o Impar");
            Console.WriteLine("5. Número mayor");
            Console.WriteLine("6. Votar con if");
            Console.WriteLine("7. Día de la semana");
            Console.WriteLine("8. Calificación con switch");
            Console.WriteLine("9. Salir");

            // Solicitar al usuario que seleccione una opción
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            // Evaluar la opción seleccionada utilizando un switch
            switch (opcion)
            {
                case 1:
                    AdivinarNumero(); // Llamada al método para adivinar un número
                    break;
                case 2:
                    ValidarEdad(); // Llamada al método para validar la edad
                    break;
                case 3:
                    Calificacion(); // Llamada al método para convertir una calificación
                    break;
                case 4:
                    ParOImpar(); // Llamada al método para determinar si un número es par o impar
                    break;
                case 5:
                    NumeroMayor(); // Llamada al método para determinar el número mayor
                    break;
                case 6:
                    VotarConIf(); // Llamada al método para verificar si puede votar
                    break;
                case 7:
                    DiaDeLaSemana(); // Llamada al método para mostrar el día de la semana
                    break;
                case 8:
                    CalificacionConSwitch(); // Llamada al método para convertir calificación usando switch
                    break;
                case 9:
                    Console.WriteLine("Saliendo del programa..."); // Mensaje de salida
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo."); // Mensaje para opciones inválidas
                    break;
            }
        } while (opcion != 9); // Repetir mientras no se seleccione la opción de salir
    }

    // Método para adivinar un número
    static void AdivinarNumero()
    {
        Random rand = new Random(); // Generador de números aleatorios
        int numeroSecreto = rand.Next(1, 101); // Número secreto entre 1 y 100
        int intento; // Variable para almacenar el intento del usuario

        Console.WriteLine("Adivina el número entre 1 y 100");
        do
        {
            Console.Write("Ingrese su intento: "); // Solicitar un intento al usuario
            intento = int.Parse(Console.ReadLine()); // Leer y convertir el intento

            // Dar pistas al usuario
            if (intento < numeroSecreto)
                Console.WriteLine("Mayor que " + intento);
            else if (intento > numeroSecreto)
                Console.WriteLine("Menor que " + intento);
            else
                Console.WriteLine("¡Correcto! El número era " + numeroSecreto);

        } while (intento != numeroSecreto); // Repetir hasta que el número sea correcto
    }

    // Método para validar si el usuario puede votar según su edad
    static void ValidarEdad()
    {
        Console.Write("Ingrese su edad: "); // Solicitar la edad al usuario
        int edad = int.Parse(Console.ReadLine()); // Leer y convertir la edad

        // Verificar si el usuario tiene edad suficiente para votar
        if (edad >= 18)
            Console.WriteLine("Puede votar.");
        else
            Console.WriteLine("No puede votar.");
    }

    // Método para convertir una calificación numérica en una letra
    static void Calificacion()
    {
        Console.Write("Ingrese la calificación (0-100): "); // Solicitar la calificación
        int calificacion = int.Parse(Console.ReadLine()); // Leer y convertir la calificación

        // Determinar la letra correspondiente según el rango
        if (calificacion >= 90)
            Console.WriteLine("A");
        else if (calificacion >= 80)
            Console.WriteLine("B");
        else if (calificacion >= 70)
            Console.WriteLine("C");
        else if (calificacion >= 60)
            Console.WriteLine("D");
        else
            Console.WriteLine("F");
    }

    // Método para determinar si un número es par o impar
    static void ParOImpar()
    {
        Console.Write("Ingrese un número: "); // Solicitar un número al usuario
        int numero = int.Parse(Console.ReadLine()); // Leer y convertir el número

        // Verificar si el número es par o impar
        if (numero % 2 == 0)
            Console.WriteLine("El número es par.");
        else
            Console.WriteLine("El número es impar.");
    }

    // Método para determinar cuál de dos números es mayor
    static void NumeroMayor()
    {
        Console.Write("Ingrese el primer número: "); // Solicitar el primer número
        int num1 = int.Parse(Console.ReadLine()); // Leer y convertir el primer número

        Console.Write("Ingrese el segundo número: "); // Solicitar el segundo número
        int num2 = int.Parse(Console.ReadLine()); // Leer y convertir el segundo número

        // Comparar los dos números
        if (num1 > num2)
            Console.WriteLine("El número mayor es: " + num1);
        else if (num2 > num1)
            Console.WriteLine("El número mayor es: " + num2);
        else
            Console.WriteLine("Ambos números son iguales.");
    }

    // Método para verificar si el usuario puede votar utilizando if
    static void VotarConIf()
    {
        Console.Write("Ingrese su edad: "); // Solicitar la edad al usuario
        int edad = int.Parse(Console.ReadLine()); // Leer y convertir la edad

        // Verificar si el usuario tiene edad suficiente para votar
        if (edad >= 18)
            Console.WriteLine("Usted puede votar.");
        else
            Console.WriteLine("Usted no puede votar.");
    }

    // Método para mostrar el día de la semana según un número
    static void DiaDeLaSemana()
    {
        Console.Write("Ingrese un número (1-7): "); // Solicitar un número al usuario
        int dia = int.Parse(Console.ReadLine()); // Leer y convertir el número

        // Determinar el día de la semana utilizando switch
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número no válido. Ingrese un número entre 1 y 7.");
                break;
        }
    }

    // Método para convertir una calificación numérica en una letra utilizando switch
    static void CalificacionConSwitch()
    {
        Console.Write("Ingrese la calificación (0-100): "); // Solicitar la calificación
        int calificacion = int.Parse(Console.ReadLine()); // Leer y convertir la calificación

        // Determinar la letra correspondiente utilizando switch
        switch (calificacion / 10)
        {
            case 10:
            case 9:
                Console.WriteLine("A");
                break;
            case 8:
                Console.WriteLine("B");
                break;
            case 7:
                Console.WriteLine("C");
                break;
            case 6:
                Console.WriteLine("D");
                break;
            default:
                Console.WriteLine("F");
                break;
        }
    }
}