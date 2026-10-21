using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        int suma = 0;

        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }

        Console.WriteLine("La suma de los dígitos es: " + suma);
    }
}