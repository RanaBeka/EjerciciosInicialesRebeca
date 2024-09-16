using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 != 0)
        {
            Debug.Log(numero1 / numero2);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
