using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int num;
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (1 < num)
        {
            i = i * 3;
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
