//la suma de  un numero del 1 al n 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número n: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma del 1 al " + n + " es: " + suma);
    }
}
