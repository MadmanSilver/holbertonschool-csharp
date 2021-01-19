using System;

/// <summary> Contains functions for matrix math. </summary>
class MatrixMath
{
    /// <summary> Multiplies two matrices. </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2) {
        if (matrix1.GetLength(1) != matrix2.GetLength(0)) {
            return new double[,] {{-1}};
        }

        double[,] res = new double[matrix1.GetLength(1),matrix1.GetLength(1)];
        double tmp = 0;
        int y1 = 0;
        int x1 = 0;
        int y2 = 0;
        int x2 = 0;

        while (y1 < matrix1.GetLength(0)) {
            while (x2 < matrix2.GetLength(1)) {
                while (x1 < matrix1.GetLength(1) || y2 < matrix2.GetLength(0)) {
                    if (x1 >= matrix1.GetLength(1)) {
                        tmp += matrix2[y2,x2];
                    } else if (y2 >= matrix2.GetLength(0)) {
                        tmp += matrix1[y1,x1];
                    } else {
                        tmp += matrix1[y1,x1] * matrix2[y2,x2];
                    }

                    x1++;
                    y2++;
                }
                res[y1,x2] = tmp;
                tmp = 0;
                x1 = 0;
                y2 = 0;
                x2++;
            }
            x2 = 0;
            y1++;
        }

        return res;
    }
}
