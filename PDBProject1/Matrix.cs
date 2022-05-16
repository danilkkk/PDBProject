using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    public delegate bool SortingType(int[] a, int[] b);

    public delegate void Sort(int[][] arr, SortingType sortingType);

    public class Matrix
    {
        public int[][] matrix = new int[][] { new int[] { 4, 3, 2, 1 }, new int[] { 2, 3, 0, 0 }, new int[] { 0, 5, 3, 2 } };

        private Sort SortingAlgorythm { get; set; }
        private SortingType SortingAlgorythmType { get; set; }

        public Matrix(IAlgorythm algoruthm, Type type)
        {
            SortingAlgorythm = new Sort(algoruthm.SortMatrix);
            SortingAlgorythmType = type.MatrixRowsComarator;
        }

        public Matrix(IAlgorythm alg)
        {
            SortingAlgorythm = new Sort(alg.SortMatrix);
        }

        public Matrix(Type type)
        {
            SortingAlgorythmType = type.MatrixRowsComarator;
        }

        public Matrix() { }

        public void setAlgorythm(IAlgorythm algorythm)
        {
            SortingAlgorythm = new Sort(algorythm.SortMatrix);
        }

        public void setType(Type arg)
        {
            SortingAlgorythmType = arg.MatrixRowsComarator;
        }

        public void SortMatrix()
        {
            if (SortingAlgorythm == null || SortingAlgorythmType == null)
            {
                return;
            }

            SortingAlgorythm(matrix, SortingAlgorythmType);
        }

        public void Show()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("( {0} )", String.Join(" ", matrix[i]));
            }
        }
    }
}
