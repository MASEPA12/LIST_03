using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NINE : MonoBehaviour
{
    public float b;
    public float h;

    void Start()
    {
        areaCalculator(b, h);
    }

    private void areaCalculator(float B,float H)
    {
        float result = (B * H)/2;
        if (B > 0 && H > 0) //if all are not 0 or negative the area canbe calculated
        {
            Debug.Log($"The area of the triangle witch base is {B} and height {H} is {result}.");
        }
        else //if B or H is equal to 0 or negative, it cannot be calculated
        {
            Debug.Log($"The area cannot be calculated.");
        }

    }
}
