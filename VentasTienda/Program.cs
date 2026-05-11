/*Ventas de una Tienda
Una tienda desea registrar las ventas diarias de una semana.*/

string[] dias = new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
float[] ventas = new float[7];
float totalVendido = 0;
int diasSuperaron150 = 0;

//Solicitar al usuario las ventas de cada día
for (int i = 0; i < ventas.Length; i++)
{
    try
    {
        Console.Write($"Ingrese las ventas del día {dias[i]}: ");
        ventas[i] = float.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: Ingrese un número válido.");
        i--;
    }
}


//Calcular el total vendido
foreach (float venta in ventas)
{
    totalVendido += venta;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nTotal vendido en la semana: ${totalVendido:F2}");
Console.ResetColor();


//Contar cuántos días las ventas superaron 150
foreach (float venta in ventas)
{
    if (venta > 150)
    {
        diasSuperaron150++;
    }
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Número de días con ventas superiores a $150: {diasSuperaron150}");
Console.ResetColor();

//Encontrar la venta más baja registrada
float ventaMasBaja = ventas[0];
foreach (float venta in ventas)
{
    if (venta < ventaMasBaja)
    {
        ventaMasBaja = venta;
    }
}
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"La venta más baja registrada es: ${ventaMasBaja:F2}");
Console.ResetColor();