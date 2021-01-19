using System;

/// <summary> Contains functions for matrix math. </summary>
class MatrixMath
{
    /// <summary> Mutliplies a matrix by a scalar. </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar) {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) {
            return new double[,] {{matrix[0,0] * scalar, matrix[0,1] * scalar}, {matrix[1,0] * scalar, matrix[1,1] * scalar}};
        }
        
        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3) {
            return new double[,] {{matrix[0,0] * scalar, matrix[0,1] * scalar, matrix[0,2] * scalar}, {matrix[1,0] * scalar, matrix[1,1] * scalar, matrix[1,2] * scalar}, {matrix[2,0] * scalar, matrix[2,1] * scalar, matrix[2,2] * scalar}};
        }

        return new double[,] {{-1}};
    }
}
