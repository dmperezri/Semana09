/*Temperaturas de la Semana
Una estación meteorológica necesita registrar las temperaturas máximas de 7 días.*/


/*
El programa debe:
Solicitar al usuario las 7 temperaturas.
Guardar los datos en un arreglo unidimensional.
Mostrar todas las temperaturas registradas.
Calcular el promedio semanal.
Indicar la temperatura más alta y la más baja.*/

double[] temperaturasMax = new double[7];
double promedio = 0;

Console.WriteLine("Registro de temperaturas máximas de la semana");
//Solicitar al usuario que ingrese las temperaturas máximas de cada día
for (int i = 0; i < temperaturasMax.Length; i++)
{
    try
    {
        Console.Write($"Día {i + 1}: ");
        temperaturasMax[i] = double.Parse(Console.ReadLine()!);
    }
    catch (Exception e)
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        i--; // Reintentar la misma iteración
    }
}

//Calcular el promedio semanal
for (int i = 0; i < temperaturasMax.Length; i++)
{
    promedio += temperaturasMax[i];
}
promedio /= temperaturasMax.Length;
Console.WriteLine($"\nPromedio semanal de temperaturas máximas: {promedio} °C");

//Indicar la temperatura más alta y la más baja
double temperaturaMasAlta = temperaturasMax[0];
double temperaturaMasBaja = temperaturasMax[0];

for (int i = 1; i < temperaturasMax.Length; i++)
{
    if (temperaturasMax[i] > temperaturaMasAlta)
    {
        temperaturaMasAlta = temperaturasMax[i];
    }

    if (temperaturasMax[i] < temperaturaMasBaja)
    {
        temperaturaMasBaja = temperaturasMax[i];
    }
}
Console.WriteLine("\nTemperaturas registradas:");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Temperatura más alta: {temperaturaMasAlta} °C");
Console.ResetColor()
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Temperatura más baja: {temperaturaMasBaja} °C");
Console.ResetColor();

