using System;

/// <summary> Contains functions for vector math. </summary>
class VectorMath
{
    /// <summary> Adds two vectors together. </summary>
    public static double[] Add(double[] vector1, double[] vector2) {
        if (vector1.Length != vector2.Length) {
            return new double[] {-1};
        }

        if (vector1.Length == 2) {
            return new double[] {vector1[0] + vector2[0], vector1[1] + vector2[2]};
        }

        if (vector1.Length == 3) {
            return new double[] {vector1[0] + vector2[0], vector1[1] + vector2[2], vector1[2] + vector2[2]};
        }

        return new double[] {-1};
    }
}
