using System;

/// <summary> Contains functions for matrix math. </summary>
class MatrixMath
{
    /// <summary> Adds two matrices together. </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2) {
        if (matrix1.Length != matrix2.Length || matrix1.GetLength(0) != matrix2.GetLength(0)) {
            return new double[,] {{-1}};
        }

        if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2) {
            return new double[,] {{matrix1[0,0] + matrix2[0,0], matrix1[0,1] + matrix2[0,1]}, {matrix1[1,0] + matrix2[1,0], matrix1[1,1] + matrix2[1,1]}};
        }

        if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3) {
            return new double[,] {{matrix1[0,0] + matrix2[0,0], matrix1[0,1] + matrix2[0,1], matrix1[0,2] + matrix2[0,2]}, {matrix1[1,0] + matrix2[1,0], matrix1[1,1] + matrix2[1,1], matrix1[1,2] + matrix2[1,2]}, {matrix1[2,0] + matrix2[2,0], matrix1[2,1] + matrix2[2,1], matrix1[2,2] + matrix2[2,2]}};
        }

        return new double[,] {{-1}};
    }
}
