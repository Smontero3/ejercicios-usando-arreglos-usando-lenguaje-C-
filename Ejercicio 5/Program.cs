using System;

class Program
{
    static void Main(string[] args)
    {
       
        int[] arreglo = new int[10];
        int mayorPrimoDigitosPares = -1;
        int posicionMayorPrimoDigitosPares = -1;
        int cantidadDigitosPares;

      
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write("Introduzca un número entero: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

       
        mayorPrimoDigitosPares = -1;
        posicionMayorPrimoDigitosPares = -1;


        for (int i = 0; i < arreglo.Length; i++)
        {
            if (esPrimo(arreglo[i]))
            {
                cantidadDigitosPares = contarDigitosPares(arreglo[i]);
                if (cantidadDigitosPares > mayorPrimoDigitosPares)
                {
                    mayorPrimoDigitosPares = arreglo[i];
                    posicionMayorPrimoDigitosPares = i;
                }
            }
        }

        if (posicionMayorPrimoDigitosPares != -1)
        {
            Console.WriteLine("El número primo con mayor cantidad de dígitos pares es {0} y se encuentra en la posición {1}", mayorPrimoDigitosPares, posicionMayorPrimoDigitosPares + 1);
        }
        else
        {
            Console.WriteLine("No se encontraron números primos con dígitos pares en el arreglo");
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

    static int contarDigitosPares(int numero)
    {
        int cantidadDigitosPares = 0;
        int numeroAbsoluto = Math.Abs(numero);

        while (numeroAbsoluto > 0)
        {
            if (numeroAbsoluto % 2 == 0)
            {
                cantidadDigitosPares++;
            }

            numeroAbsoluto /= 10;
        }

        return cantidadDigitosPares;
    }
}
