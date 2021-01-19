﻿using System;

class VectorMath
{
    public static double Magnitude(double[] vector) {
        if (vector.length == 2) {
            return Math.sqrt(vector[0] * vector[0] + vector[1] * vector[1]);
        }

        if (vector.length == 3) {
            return Math.sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);
        }

        return -1;
    }
}