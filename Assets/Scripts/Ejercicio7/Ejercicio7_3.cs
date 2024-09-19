using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int i = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (i > 0)
        {
            i--;
            Debug.Log(i);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
