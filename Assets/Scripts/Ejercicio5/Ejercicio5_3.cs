using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero <9 && numero >0)
        {
            Debug.Log("El numero es menor que 9 y mayor que 0");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
