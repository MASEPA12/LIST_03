using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWO : MonoBehaviour
{
    public int number;
    void Start()
    { //if the function is true or false...
        if(isEven(number) == true)
        {
            Debug.Log($"The number {number} is even.");
        }
        else
        {
            Debug.Log($"The number {number} is NOT even.");
        }
    }
    private bool isEven(int N)
    { //if the number can be divided by 2 (that it's quotient is 0) it will be even
        int result = N % 2;
        if(result == 0)
        {
            return true;
        }
        return false;
    }
}
