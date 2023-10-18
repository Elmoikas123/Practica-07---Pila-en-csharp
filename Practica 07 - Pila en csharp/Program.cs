using System;
class Program
{
    static void Main()
    {
        const int capacidad = 10;
        int[] elementos = new int[capacidad];
        int tope = -1;

        Console.WriteLine("Teclea el elemento de la pila(Termina con -1)");
        int x = 0;
        const int CLAVE = -1;
        while (x != CLAVE)
        {
            try
            {
                x = int.Parse(Console.ReadLine());
                if (tope < capacidad - 1)
                {
                    tope++;
                    elementos[tope] = x;
                }
                else
                {
                    Console.WriteLine("Excepcion: Pila LLena");
                    break;
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Excepcion: Entrada No Valida");
            }
        }

        if (tope >= 0)
        {
            Console.WriteLine("Elementos De La Pila:");
            while (tope >= 0)
            {
                x = elementos[tope];
                tope--;
                Console.WriteLine(x + " ");

            }
            Console.ReadLine();
        }

        else
        {
            Console.WriteLine("Pila Vacia");
        }
    }
}