using BusquedaLineal;

namespace BusLi
{
    class program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Console.WriteLine("El arreglo es: ");
            foreach (int i in num)
            {
                Console.Write(i + " , ");
            }

            int x = 8;
            int indice = BusquedaLineal.BusquedaLineal.linearSearch(num, x);

            if(indice == -1)
            {
                Console.WriteLine("Busqueda erronea");
            }else
            {
                Console.WriteLine("el elemento {0} existe en la posición {1} ", x, indice);
            }
        }
    }
}