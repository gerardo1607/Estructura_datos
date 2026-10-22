//invertir los digitos en numero
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        int invertido = 0;

        while (numero > 0)
        {
            int digito = numero % 10;
            invertido = invertido * 10 + digito;
            numero /= 10;
        }

        Console.WriteLine("Número invertido: " + invertido);
    }
}
