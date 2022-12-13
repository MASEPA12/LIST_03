using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THREE : MonoBehaviour
{
    public int dividend; 
    public int divisor; 
        
    void Start()
    {   //if one of the numbers is 0, we cannot divide 
        if (dividend == 0 || divisor == 0)
        {
            Debug.Log("The division cannot be made");
        }
        else //but if the're not, we call the function
        {
            isExact(dividend, divisor);
        }
    }

    private void isExact(int D, int d)
    {
        int result = D % d;
        if (result == 0)
        {
            Debug.Log($"The division between {D} and {divisor} is exact");
        }
        else
        {
            Debug.Log($"The division between {D} and {d} is not exact");
        }
    }

}
