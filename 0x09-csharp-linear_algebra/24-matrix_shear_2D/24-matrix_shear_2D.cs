using System;

/// <summary> Contains functions for matrix math. </summary>
class MatrixMath
{
    /// <summary> Shears a 2D matrix by a given factor. </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor) {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) {
            if (direction == 'x') {
                return new double[,] {{matrix[0,0] + factor * matrix[0,1], matrix[0,1]}, {matrix[1,0] + factor * matrix[1,1], matrix[1,1]}};
            }

            if (direction == 'y') {
                return new double[,] {{matrix[0,0], matrix[0,1] + factor * matrix[0,0]}, {matrix[1,0], matrix[1,1] + factor * matrix[1,0]}};
            }
        }

        return new double[,] {{-1}};
    }
}
