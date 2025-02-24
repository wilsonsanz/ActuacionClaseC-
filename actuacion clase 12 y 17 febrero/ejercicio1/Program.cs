// Definimos la interfaz Operacion con los métodos abstractos
public interface Operacion
{
    double Sumar(double a, double b);
    double Restar(double a, double b);
    double Multiplicar(double a, double b);
    double Dividir(double a, double b);
}

// Implementams la interfaz en la clase Calculadora
public class Calculadora : Operacion
{
    // Método para sumar dos números
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    // Método para restar dos números
    public double Restar(double a, double b)
    {
        return a - b;
    }

    // Método para multiplicar dos números
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    // Método para dividir dos números, manejando la división por cero
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return double.NaN; // Devuelve un valor especial indicando error
        }
        return a / b;
    }
}

// Programa principal para proba la clase Calculadora
class Programa
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();

        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Suma: " + calculadora.Sumar(num1, num2));
        Console.WriteLine("Resta: " + calculadora.Restar(num1, num2));
        Console.WriteLine("Multiplicación: " + calculadora.Multiplicar(num1, num2));
        Console.WriteLine("División: " + calculadora.Dividir(num1, num2));

        // Prueba de división entre cero
        Console.WriteLine("Prueba de división entre cero: " + calculadora.Dividir(num1, 0));
    }
}
