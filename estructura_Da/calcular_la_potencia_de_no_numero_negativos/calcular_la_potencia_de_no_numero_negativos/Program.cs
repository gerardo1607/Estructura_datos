//calcular la potencia 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el exponente (no negativo): ");
        int exponente = int.Parse(Console.ReadLine());

        int resultado = 1;

        if (exponente >= 0)
        {
            for (int i = 1; i <= exponente; i++)
            {
                resultado *= baseNum;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
        else
        {
            Console.WriteLine("El exponente debe ser no negativo.");
        }
    }
}
