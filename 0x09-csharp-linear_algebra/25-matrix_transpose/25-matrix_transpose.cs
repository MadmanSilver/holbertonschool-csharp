using System;

/// <summary> Contains functions for matrix math. </summary>
class MatrixMath
{
    /// <summary> Transposes a matrix. </summary>
    public static double[,] Transpose(double[,] matrix) {
        double[,] res = new double[matrix.GetLength(1),matrix.GetLength(0)];

        for (int y = 0; y < matrix.GetLength(1); y++) {
            for (int x = 0; x < matrix.GetLength(0); x++) {
                res[y,x] = matrix[x,y];
            }
        }

        return res;
    }
}
