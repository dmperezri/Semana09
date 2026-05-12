/*Inventario de una Librería
Una librería necesita registrar las ventas de libros por categoría.*/


float promedioVentas, totalVentas;
string[] categorias = { "Ficción", "Romance", "Terror", "Ciencia Ficción", "Arte" };
int[] ventas = new int[categorias.Length];
int maxVentas;
string categoriaMaxVentas;

//solicitar la cantidad de libros vendidos en 5 categorías: ficción, romance, terror, cienciaficcion y arte.
//Y guardar esa información en un arreglo.
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Ingrese la cantidad de libros vendidos por categoría:");
Console.WriteLine("----------------------------------------------------------------");
for (int i = 0; i < categorias.Length; i++)
{
    try
    {
        Console.Write($"{categorias[i]}: ");
        ventas[i] = int.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número válido.");
        Console.ResetColor();
        i--;
    }
}


//Mostrar el total de libros vendidos por categoría.
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n-------------------------------------------------------------");
Console.WriteLine("      Total de libros vendidos por categoría:");
Console.WriteLine("---------------------------------------------------------------");
for (int i = 0; i < categorias.Length; i++)
{
    Console.WriteLine($"{categorias[i]}: {ventas[i]} libros");
}


//Indicar cuál es la categoría con más ventas.
maxVentas = ventas[0];
categoriaMaxVentas = categorias[0];
for (int i = 1; i < categorias.Length; i++)
{
    if (ventas[i] > maxVentas)
    {
        maxVentas = ventas[i];
        categoriaMaxVentas = categorias[i];
    }
}
Console.WriteLine($"La categoría con más ventas es: {categoriaMaxVentas} con {maxVentas} libros vendidos.");
Console.WriteLine("----------------------------------------------------------------");

//Calcular el promedio deventas.
totalVentas = 0;
for (int i = 0; i < ventas.Length; i++)
{
    totalVentas += ventas[i];
}
promedioVentas = totalVentas / ventas.Length;
Console.WriteLine($"El promedio de ventas es: {promedioVentas:F2}.");
Console.WriteLine("---------------------------------------------------------------");
Console.ResetColor();

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();
Console.Clear();

