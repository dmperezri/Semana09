using System.Globalization;

// Programa: Notas de estudiantes (8 alumnos)
const int NumeroEstudiantes = 8;
float[] notas = new float[NumeroEstudiantes];
float nota, promedio;
int reprobados = 0;

Console.Clear();
Console.WriteLine("===============================================================");
Console.WriteLine("Ingrese la nota final de cada uno de los 8 estudiantes (0-100):");
Console.WriteLine("===============================================================");
for (int i = 0; i < NumeroEstudiantes; i++)
{
    Console.Write($"Estudiante {i + 1}: ");
    try
    {
        nota = float.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        if (nota < 0 || nota > 100)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("La nota debe estar entre 0 y 100. Intente nuevamente.");
            Console.ResetColor();
            i--; // Decrementar para repetir la entrada de este estudiante
        }
        else
        {
            notas[i] = nota;
        }
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Ingrese un número entre 0 y 100.");
        Console.ResetColor();
        i--; // Decrementar para repetir la entrada de este estudiante
    }

}

// Mostrar únicamente las notas aprobadas 
Console.WriteLine("\n------------------------------");
Console.WriteLine("         Notas aprobadas:");
Console.WriteLine("------------------------------");
float suma = 0;
for (int i = 0; i < NumeroEstudiantes; i++)
{
    suma += notas[i];
    if (notas[i] >= 70)
    {
        Console.WriteLine($"Estudiante {i + 1}: {notas[i]:F2}");
    }
    else
    {
        reprobados++;
    }
}
promedio = suma / NumeroEstudiantes;
Console.WriteLine("------------------------------");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Número de estudiantes reprobados: {reprobados}");
Console.ResetColor();

Console.WriteLine("------------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Promedio general del grupo: {promedio:F2}");
Console.ResetColor();
Console.WriteLine("------------------------------");


Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();
Console.Clear();