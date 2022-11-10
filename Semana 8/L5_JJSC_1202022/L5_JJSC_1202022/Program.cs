// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1");
Console.WriteLine("Ingrese un número entero");
try
{
    int num = int.Parse(Console.ReadLine());

    if (num > 0)
    {
        Console.WriteLine("El número es positivo");
    }
    else if (num == 0)
    {
        Console.WriteLine("El número es 0");
    }
    else
    {
        Console.WriteLine("El número es negativo");
    }
    Console.ReadKey();
}
catch(FormatException exception)
{
    Console.WriteLine("No ingresó un número" + exception);
    Console.ReadKey();
}

Console.Clear();