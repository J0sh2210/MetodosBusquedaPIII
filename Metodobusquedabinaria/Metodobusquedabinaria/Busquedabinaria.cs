using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodobusquedabinaria
{
    public class Busquedabinaria
    {
        public static int binarysearch(int[] num, int x)
        {
            int low = 0, high = num.Length;
            while (low <= high) {
                int mid = (low + high) / 2;
                if (num[mid] == x)
                {
                    return mid;
                } else if (num[mid] < x) {
                    low = mid + 1;
                }else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
