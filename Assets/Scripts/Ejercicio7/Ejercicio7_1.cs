using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio7_1 : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
