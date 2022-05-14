using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    public class MinType : Type
    {
        public MinType(bool val) : base(val) { }
        public override bool MatrixRowsComarator(int[] a, int[] b)
        {
            int minA = a[0];
            int minB = b[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minA)
                {
                    minA = a[i];
                }
                if (b[i] < minB)
                {
                    minB = b[i];
                }
            }
            return ascending ? minB < minA : minB > minA;
        }
    }
}
