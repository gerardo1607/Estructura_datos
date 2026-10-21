using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine("El número no es negativo.");

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
        else
        {
            Console.WriteLine("El número es negativo.");
        }
    }
}
