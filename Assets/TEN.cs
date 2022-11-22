using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEN : MonoBehaviour
{
    void Update()
    {   //if we click the space it calls the function getBigger
        if (Input.GetKeyDown(KeyCode.Space))
        {
            getBigger();
        }
    }

    void getBigger()
    {   //+ (1,1,1) to the scale of the Game Object 
        transform.localScale += Vector3.one; 
    }

}
        
    