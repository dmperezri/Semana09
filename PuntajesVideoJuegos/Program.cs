/*Puntajes de un Videojuego
Un jugador desea almacenar los puntajes obtenidos en diferentes partidas.*/

//Solicitar al usuario que ingrese los puntajes obtenidos en cada partida (6 partidos).

int[] puntajes = new int[6];
int puntajeMasAlto = puntajes[0];
int PuntajesMayoresA500 = 0;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---------------------------------");
Console.WriteLine("  PUNTAJES DE UN VIDEOJUEGO" );
Console.WriteLine("---------------------------------");
Console.ResetColor();

Console.WriteLine("\nIngrese los puntajes obtenidos en cada partida:");
for (int i = 0; i < puntajes.Length; i++)
{
   try
   {
        Console.Write($"Partida {i + 1}: ");
        puntajes[i] = int.Parse(Console.ReadLine()!);
   }
   catch (Exception e)
   {
        Console.WriteLine("Error: Ingrese un número válido.");
        i--;
   }
}

//Mostrar el puntaje más alto
for (int i = 1; i < puntajes.Length; i++)
{
    if (puntajes[i] > puntajeMasAlto)
    {
        puntajeMasAlto = puntajes[i];
    }
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nEl puntaje más alto es: {puntajeMasAlto}");
Console.ResetColor();

//Ordenar los puntajes de menor a mayor
//Array.Sort(puntajes);
for (int i = 0; i < puntajes.Length - 1; i++)
{
    for (int j = 0; j < puntajes.Length - i - 1; j++)
    {
        if (puntajes[j] > puntajes[j + 1])
        {
            int temp = puntajes[j];
            puntajes[j] = puntajes[j + 1];
            puntajes[j + 1] = temp;
        }
    }
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\nPuntajes ordenados de menor a mayor:");
foreach (int puntaje in puntajes)
{
    Console.WriteLine(puntaje);
}

//Contar cuantos puntajes son mayores a 500
foreach (int puntaje in puntajes)
{
    if (puntaje > 500)
    {
        PuntajesMayoresA500++;
    }
}
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"\nCantidad de puntajes mayores a 500: {PuntajesMayoresA500}");
Console.ResetColor();

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();
Console.Clear();