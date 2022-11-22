using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EIGHT : MonoBehaviour
{
    public int year;
    void Start()
    {
        if(isLeapYear(year) == true)
        {
            Debug.Log($"The year {year} is a leap year.");
        }
        else
        {
            Debug.Log($"This year {year} is not a leap year.");
        }
    }

    
    private bool isLeapYear(int Y)
    {
        int module1 = Y % 4;
        int module2 = Y % 100;
        int module3 = Y % 400;

        if(module1 == 0 || (module1 == 0 && module2 == 0 && module3 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
