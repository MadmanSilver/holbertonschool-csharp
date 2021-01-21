using System;

/// <summary> Contains functions for matrix math. </summary>
class MatrixMath
{
    /// <summary> Calculates the inverse of a matrix. </summary>
    public static double[,] Inverse2D(double[,] matrix) {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2) {
            return new double[,] {{-1}};
        }

        double det = matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];

        if (det == 0) {
            return new double[,] {{-1}};
        }

        return new double[,] {{Math.Round(matrix[1,1] / det, 2), Math.Round(-matrix[0,1] / det, 2)}, {Math.Round(-matrix[1,0] / det, 2), Math.Round(matrix[0,0] / det, 2)}};
    }
}
