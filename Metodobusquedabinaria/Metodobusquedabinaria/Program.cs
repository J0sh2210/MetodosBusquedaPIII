using Metodobusquedabinaria;
using System;
namespace BB
{
    class program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            Console.WriteLine("El arreglo es: ");
            foreach (int i in num)
            {
                Console.Write(i + " , ");
            }
            int x = 4;

            int indice = Busquedabinaria.binarysearch(num, x);

            if (indice == -1)
            {
                Console.WriteLine("La búsqueda no existe");
            } else
            {
                Console.WriteLine(" el elemento {0} existe en la posición {1}", x, indice);
            }
            


        }
    }
}