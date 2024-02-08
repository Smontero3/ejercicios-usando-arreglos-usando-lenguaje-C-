using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] arreglo = new int[10];
        int[] posicionesNumerosConMasDe3Digitos = new int[10];
        int cantidadNumerosConMasDe3Digitos = 0;

    
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write("Introduzca un número entero: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (contarDigitos(arreglo[i]) > 3)
            {
                posicionesNumerosConMasDe3Digitos[cantidadNumerosConMasDe3Digitos] = i;
                cantidadNumerosConMasDe3Digitos++;
            }
        }


        if (cantidadNumerosConMasDe3Digitos > 0)
        {
            Console.WriteLine("Los números con más de 3 dígitos se encuentran en las posiciones:");
            for (int i = 0; i < cantidadNumerosConMasDe3Digitos; i++)
            {
                Console.WriteLine(" - Posición {0}", posicionesNumerosConMasDe3Digitos[i] + 1);
            }
        }
        else
        {
            Console.WriteLine("No se encontraron números con más de 3 dígitos en el arreglo");
        }
    }

    static int contarDigitos(int numero)
    {
        int cantidadDigitos = 0;
        int numeroAbsoluto = Math.Abs(numero);

        while (numeroAbsoluto > 0)
        {
            cantidadDigitos++;
            numeroAbsoluto /= 10;
        }

        return cantidadDigitos;
    }
}
