//convertir numero en binario
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número decimal entero: ");
        int numero = int.Parse(Console.ReadLine());

        string binario = Convert.ToString(numero, 2);

        Console.WriteLine("El número en binario es:" + binario);
    }
}
