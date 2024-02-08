using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] arreglo = new int[10];
        int cantidadNumerosPrimo = 0;

        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write("Introduzca un número entero: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

   
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (esDigitoPrimo(arreglo[i]))
            {
                cantidadNumerosPrimo++;
            }
        }


        Console.WriteLine("Cantidad de números que comienzan con dígito primo: {0}", cantidadNumerosPrimo);
    }

    static bool esDigitoPrimo(int numero)
    {
        int primerDigito = Math.Abs(numero) / 10;

        if (primerDigito <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(primerDigito); i++)
        {
            if (primerDigito % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
