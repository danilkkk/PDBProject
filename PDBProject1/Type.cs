using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    public abstract class Type
    {
        public bool ascending { get; private set; }

        public Type(bool ascending)
        {
            this.ascending = ascending;
        }

        public abstract bool MatrixRowsComarator(int[] a, int[] b);
    }
}
