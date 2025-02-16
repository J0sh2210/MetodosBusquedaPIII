using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaLineal
{
    public class BusquedaLineal
    {
        public static int linearSearch(int[] num, int x)
        {
            int n = num.Length;
            for (int i = 0; i < n; i++)
            {
                if (num[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
