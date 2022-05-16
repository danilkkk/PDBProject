using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    public class BubleSort : IAlgorythm
    {
        public void SortMatrix(int[][] arr, SortingType sort)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k <= arr.Length - 2; k++)
                {
                    int[] temp;
                    {
                        if (sort(arr[k], arr[k + 1]))
                        {
                            temp = arr[k];
                            arr[k] = arr[k + 1];
                            arr[k + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
