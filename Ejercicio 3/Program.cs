using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] arreglo = new int[10];
        int mayorPrimo = -1;
        int posicionMayorPrimo = -1;

        
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write("Introduzca un número entero: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

       
        mayorPrimo = -1;
        posicionMayorPrimo = -1;

    
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (esPrimo(arreglo[i]))
            {
                if (arreglo[i] > mayorPrimo)
                {
                    mayorPrimo = arreglo[i];
                    posicionMayorPrimo = i;
                }
            }
        }

       
        if (posicionMayorPrimo != -1)
        {
            Console.WriteLine("El mayor número primo es {0} y se encuentra en la posición {1}", mayorPrimo, posicionMayorPrimo + 1);
        }
        else
        {
            Console.WriteLine("No se encontraron números primos en el arreglo");
        }
    }

    static bool esPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
