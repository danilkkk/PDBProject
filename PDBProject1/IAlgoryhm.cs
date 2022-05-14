using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    public interface IAlgorythm
    {
        void SortMatrix(ref int[][] arr, SortingType asc);
    }
}
