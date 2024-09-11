using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 5;
    float exp = 6.5f;
    char carac = 'A';
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas);
        Debug.Log(exp);
        float resultadoSuma = vidas + exp;
        float resultadoResta = exp - vidas;
        Debug.Log(resultadoSuma + " " + resultadoResta);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
