using System;

/// <summary> Contains functions for matrix math. </summary>
class MatrixMath
{
    /// <summary> Rotates a 2D matrix by radians. </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle) {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) {
            return new double[,] {{Math.Round(matrix[0,0] * Math.Cos(angle) - matrix[0,1] * Math.Sin(angle), 2), Math.Round(matrix[0,0] * Math.Sin(angle) + matrix[0,1] * Math.Cos(angle), 2)}, {Math.Round(matrix[1,0] * Math.Cos(angle) - matrix[1,1] * Math.Sin(angle), 2), Math.Round(matrix[1,0] * Math.Sin(angle) + matrix[1,1] * Math.Cos(angle), 2)}};
        }

        return new double[,] {{-1}};
    }
}
