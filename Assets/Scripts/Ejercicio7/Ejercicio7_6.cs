using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    int num = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (num > -101)
        {
            num--;
            Debug.Log(num);
        }
        for (int num = 1; num > -101; num--)
        {
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
