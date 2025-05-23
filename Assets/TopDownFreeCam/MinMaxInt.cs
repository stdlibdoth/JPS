using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct MinMaxInt
{
    public int min;
    public int max;

    public int Difference
    {
        get
        {
            return max - min;
        }
    }

    public MinMaxInt(int min, int max)
    {
        this.min = min <= max ? min : max;
        this.max = max > min ? max : min;
    }

    public MinMaxInt(MinMaxInt min_max)
    {
        min = min_max.min;
        max = min_max.max;
    }
}

[System.Serializable]
public struct MinMax
{
    public float min;
    public float max;

    public float Difference
    {
        get
        {
            return max - min;
        }
    }

    public MinMax(float min, float max)
    {
        this.min = min <= max ? min : max;
        this.max = max > min ? max : min;
    }

    public MinMax(MinMaxInt min_max)
    {
        min = min_max.min;
        max = min_max.max;
    }
}
