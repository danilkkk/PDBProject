using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    public class SumType : Type
    {
        public SumType(bool val) : base(val) { }
        public override bool MatrixRowsComarator(int[] a, int[] b)
        {
            int sumA = 0;
            int sumB = 0;

            foreach (int i in a)
            {
                sumA += i;
            }

            foreach (int i in b)
            {
                sumB += i;
            }

            return ascending ? sumB < sumA : sumB > sumA;
        }
    }
}
