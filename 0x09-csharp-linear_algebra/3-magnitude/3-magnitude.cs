﻿using System;

/// <summary> Contains vector math functions. </summary>
class VectorMath
{
    /// <summary> Calculates the magnitude of a vector. </summary>
    public static double Magnitude(double[] vector) {
        if (vector.Length == 2) {
            return Math.Round(Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1]), 2);
        }

        if (vector.Length == 3) {
            return Math.Round(Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]), 2);
        }

        return -1;
    }
}
