using System;

class PiedraPapelTijera
{
    // Variables globales para las puntuaciones
    static int puntosJugador = 0; // Almacena los puntos del jugador
    static int puntosComputadora = 0; // Almacena los puntos de la computadora

    static void Main()
    {
        // Mensaje de bienvenida
        Console.WriteLine("¡Bienvenido al juego de Piedra, Papel o Tijera!");
        Console.WriteLine("Escribe 'piedra', 'papel' o 'tijera' para jugar. Escribe 'salir' para terminar el juego.");

        // Opciones disponibles para el juego
        string[] opciones = { "piedra", "papel", "tijera" };

        // Clase Random para generar elecciones aleatorias para la computadora
        Random random = new Random();

        // Variable para almacenar la elección del jugador
        string eleccionJugador;

        do
        {
            // Solicitar al jugador que ingrese su elección
            Console.Write("\nTu elección: ");
            eleccionJugador = Console.ReadLine()?.ToLower(); // Leer y convertir a minúsculas

            // Verificar si el jugador desea salir del juego
            if (eleccionJugador == "salir")
                break; // Salir del bucle si el jugador escribe "salir"

            // Validar si la elección del jugador es válida
            if (!Array.Exists(opciones, opcion => opcion == eleccionJugador))
            {
                Console.WriteLine("Opción inválida. Intenta nuevamente."); // Mensaje de error
                continue; // Volver al inicio del bucle
            }

            // Generar una elección aleatoria para la computadora
            string eleccionComputadora = opciones[random.Next(0, 3)];
            Console.WriteLine($"La computadora eligió: {eleccionComputadora}"); // Mostrar elección de la computadora

            // Evaluar quién ganó la ronda
            EvaluarGanador(eleccionJugador, eleccionComputadora);

            // Mostrar la puntuación actual
            MostrarPuntuacion();
        } while (true); // Repetir hasta que el jugador escriba "salir"

        // Mensaje de despedida
        Console.WriteLine("\n¡Gracias por jugar!");
    }

    // Función para evaluar el ganador de la ronda
    static void EvaluarGanador(string jugador, string computadora)
    {
        // Caso de empate
        if (jugador == computadora)
        {
            Console.WriteLine("¡Empate!"); // Mensaje de empate
        }
        // Caso en que el jugador gana
        else if ((jugador == "piedra" && computadora == "tijera") ||
                 (jugador == "papel" && computadora == "piedra") ||
                 (jugador == "tijera" && computadora == "papel"))
        {
            Console.WriteLine("¡Ganaste esta ronda!"); // Mensaje de victoria del jugador
            puntosJugador++; // Incrementar puntuación del jugador
        }
        // Caso en que la computadora gana
        else
        {
            Console.WriteLine("La computadora gana esta ronda."); // Mensaje de victoria de la computadora
            puntosComputadora++; // Incrementar puntuación de la computadora
        }
    }

    // Función para mostrar la puntuación actual
    static void MostrarPuntuacion()
    {
        // Mostrar los puntos del jugador y la computadora
        Console.WriteLine($"Puntuación: Jugador {puntosJugador} - Computadora {puntosComputadora}");
    }
}
