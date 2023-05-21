using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrganizer
{
    internal class MatrixHelper
    {
        private static readonly ConcurrentDictionary<int, double[,]> listTransMatrix =
            new ConcurrentDictionary<int, double[,]>();
        public static double[,] GetTransMatrix(int precision)
        {
            return listTransMatrix.GetOrAdd(precision, key =>
            {
                // Generate transformation matrix
                var transMatrix = new double[key, key];
                for (var i = 0; i < transMatrix.GetUpperBound(0) + 1; i++)
                for (var j = 0; j < transMatrix.GetUpperBound(1) + 1; j++)
                {
                    var ci = i == 0 ? Math.Sqrt(1.0 / key) : Math.Sqrt(2.0 / key);
                    transMatrix[i, j] = ci * Math.Cos(Math.PI * (j + 0.5) * i / key);
                }

                return transMatrix;
            });
        }

        public static double[,] GetTansposedMatrix(double[,] matrix)
        {
            int row = matrix.GetUpperBound(0) + 1;
            int column = matrix.GetUpperBound(1) + 1;
            double[,] newMatrix = new double[column, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    newMatrix[j, i] = matrix[i, j];
                }
            }
            return newMatrix;
        }

        public static double[,] MultiplyMatrixes(double[,] matrixA, double[,] matrixB)
        {
            int aRows = matrixA.GetUpperBound(0) + 1;
            int aCols = matrixA.GetUpperBound(1) + 1;
            int bRows = matrixB.GetUpperBound(0) + 1;
            int bCols = matrixB.GetUpperBound(1) + 1;
            if (aCols != bRows)
            { throw new Exception("Non-conformable matrices in MatrixProduct"); }

            double[,] result = new double[aRows, bCols];
            Parallel.For(0, aRows, i =>
            {
                for (int j = 0; j < bCols; ++j)
                for (int k = 0; k < aCols; ++k)
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
            });
            return result;
        }
    }
}
