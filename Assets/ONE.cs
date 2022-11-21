using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONE : MonoBehaviour
{
    public string letter;

    private void Start()
    {
        if(IsVowel(letter) == true)
        {
            Debug.Log($"The letter {letter} is a vowel");
        }
        else
        {
            Debug.Log($"The letter {letter} is not a vowel");
        }
    }

    //function;
    private bool IsVowel(string L)
    {
        if(L == "a" || L == "e" || L == "i" || L == "o"|| L == "u")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
