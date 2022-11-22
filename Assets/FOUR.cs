using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOUR : MonoBehaviour
{
    public Vector3 Movement;

    void Start()
    {   //calling the funciton
        Vector(Movement);
    }
    private void Vector(Vector3 R)
    {   //convert the position of the Game Object to R
        transform.Translate(R);
    }
}
