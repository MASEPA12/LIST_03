using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIX : MonoBehaviour
{
    //variable declaration
    public float number1;
    public float number2;

    void Start()
    {   //call the function
        isGreater(number1, number2); 
    }

    private float isGreater(float A,float B)
    {
        if(A > B) //if A is greater than B...
        {
            Debug.Log($"{A} is greater than {B}.");
            return A;
        }
        else if( A == B)
        {   //if A is equal to B...
            Debug.Log("The two numbers are equal.");
            return A;
        }
        else
        {   //if B is greater than A...
            Debug.Log($"{B} is greater than {A}.");
            return B;
        }
    }
}
