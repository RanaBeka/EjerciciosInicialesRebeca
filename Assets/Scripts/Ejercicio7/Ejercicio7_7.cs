using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int menor;
    [SerializeField] int mayor;
    // Start is called before the first frame update
    void Start()
    {
        while (menor < mayor)
        {
            menor++;
            Debug.Log(menor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
