using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (i < 101)
        {
            i++;
            Debug.Log(i);
        }
        for (int x = 0; x < 101; x++)
        {
            Debug.Log(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
