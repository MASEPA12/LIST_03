using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVE : MonoBehaviour
{
    public int Number;

    void Start()
    {
        MultuplicatonTable(Number, 1);
        MultuplicatonTable(Number, 2);
        MultuplicatonTable(Number, 3);
        MultuplicatonTable(Number, 4);
        MultuplicatonTable(Number, 5);
        MultuplicatonTable(Number, 6);
        MultuplicatonTable(Number, 7);
        MultuplicatonTable(Number, 8);
        MultuplicatonTable(Number, 9);
        MultuplicatonTable(Number, 10);
    }

    private void MultuplicatonTable(int n, int N)
    {
        int result1 = n * N;
        Debug.Log($"{n} x {N} = {result1}");
    }
}
