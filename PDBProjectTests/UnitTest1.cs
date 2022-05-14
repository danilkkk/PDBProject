using NUnit.Framework;
using PDBProject1;

namespace PDBProjectTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void sumAscTest()
        {
            Matrix matrix = new Matrix(new BubleSort(), new SumType(true));
            matrix.SortMatrix();

            int[][] rightSortedMatrix = new int[][] { new int[] { 2, 3, 0, 0 }, new int[] { 4, 3, 2, 1 }, new int[] { 0, 5, 3, 2 } };

            for (var i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.matrix[i].GetLength(0); j++)
                {

                    if (matrix.matrix[i][j] != rightSortedMatrix[i][j])
                    {
                        Assert.Fail($"Элемент matrix[{i},{j}] имеет значение {matrix.matrix[i][j]}, а должен - {rightSortedMatrix[i][j]}");
                    }
                }
            }
        }

        [Test]
        public void sumDescTest()
        {
            Matrix matrix = new Matrix(new BubleSort(), new SumType(false));
            matrix.SortMatrix();

            int[][] rightSortedMatrix = new int[][] { new int[] { 4, 3, 2, 1 }, new int[] { 0, 5, 3, 2 }, new int[] { 2, 3, 0, 0 } };

            for (var i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.matrix[i].GetLength(0); j++)
                {

                    if (matrix.matrix[i][j] != rightSortedMatrix[i][j])
                    {
                        Assert.Fail($"Элемент matrix[{i},{j}] имеет значение {matrix.matrix[i][j]}, а должен - {rightSortedMatrix[i][j]}");
                    }
                }
            }
        }

        [Test]
        public void maxAscTest()
        {
            Matrix matrix = new Matrix(new BubleSort(), new MaxType(true));
            matrix.SortMatrix();

            int[][] rightSortedMatrix = new int[][] { new int[] { 2, 3, 0, 0 }, new int[] { 4, 3, 2, 1 }, new int[] { 0, 5, 3, 2 } };

            for (var i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.matrix[i].GetLength(0); j++)
                {

                    if (matrix.matrix[i][j] != rightSortedMatrix[i][j])
                    {
                        Assert.Fail($"Элемент matrix[{i},{j}] имеет значение {matrix.matrix[i][j]}, а должен - {rightSortedMatrix[i][j]}");
                    }
                }
            }
        }

        [Test]
        public void maxDescTest()
        {
            Matrix matrix = new Matrix(new BubleSort(), new MaxType(false));
            matrix.SortMatrix();

            int[][] rightSortedMatrix = new int[][] { new int[] { 0, 5, 3, 2 }, new int[] { 4, 3, 2, 1 }, new int[] { 2, 3, 0, 0 } };

            for (var i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.matrix[i].GetLength(0); j++)
                {

                    if (matrix.matrix[i][j] != rightSortedMatrix[i][j])
                    {
                        Assert.Fail($"Элемент matrix[{i},{j}] имеет значение {matrix.matrix[i][j]}, а должен - {rightSortedMatrix[i][j]}");
                    }
                }
            }
        }

        [Test]
        public void minAscTest()
        {
            Matrix matrix = new Matrix(new BubleSort(), new MinType(true));
            matrix.SortMatrix();

            int[][] rightSortedMatrix = new int[][] { new int[] { 2, 3, 0, 0 }, new int[] { 0, 5, 3, 2 },  new int[] { 4, 3, 2, 1 } };

            for (var i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.matrix[i].GetLength(0); j++)
                {

                    if (matrix.matrix[i][j] != rightSortedMatrix[i][j])
                    {
                        Assert.Fail($"Элемент matrix[{i},{j}] имеет значение {matrix.matrix[i][j]}, а должен - {rightSortedMatrix[i][j]}");
                    }
                }
            }
        }

        [Test]
        public void minDescTest()
        {
            Matrix matrix = new Matrix(new BubleSort(), new MinType(false));
            matrix.SortMatrix();

            int[][] rightSortedMatrix = new int[][] { new int[] { 4, 3, 2, 1 }, new int[] { 2, 3, 0, 0 }, new int[] { 0, 5, 3, 2 } };

            for (var i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.matrix[i].GetLength(0); j++)
                {

                    if (matrix.matrix[i][j] != rightSortedMatrix[i][j])
                    {
                        Assert.Fail($"Элемент matrix[{i},{j}] имеет значение {matrix.matrix[i][j]}, а должен - {rightSortedMatrix[i][j]}");
                    }
                }
            }
        }

        [Test]
        public void CountdownTest()
        {
            Assert.Pass(); // FIXME
        }


    }
}