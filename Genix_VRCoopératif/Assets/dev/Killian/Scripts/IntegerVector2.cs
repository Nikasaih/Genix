using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct IntegerVector2
{
    public int x, z;

    public IntegerVector2(int x, int z)
    {
        this.x = x;
        this.z = z;
    }

    public static IntegerVector2 operator +(IntegerVector2 a, IntegerVector2 b)
    {
        a.x += b.x;
        a.z += b.z;
        return a;
    }
}