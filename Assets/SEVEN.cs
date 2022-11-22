using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEVEN : MonoBehaviour
{
    //variable declaration
    public float number;

    void Start()
    {
        absoluteValue(number);
    }

    //if the number is negative, it will be lesser than 0, so if we multiply the number with -1, it will show the number positive  
    private void absoluteValue(float N)
    {
        if (N < 0)
        {
            N *= -1;
        }
        Debug.Log($"{N}");
    }
}
