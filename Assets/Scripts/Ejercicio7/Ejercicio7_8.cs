using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int menor;
    [SerializeField] int mayor;
    // Start is called before the first frame update
    void Start()
    {
        while (menor < mayor)
        {
            menor = menor +2;
            Debug.Log(menor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
