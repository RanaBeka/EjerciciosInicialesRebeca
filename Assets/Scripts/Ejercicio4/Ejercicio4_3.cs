using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        float resultado = Convertir(5f, "euro");
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Convertir(float cantidad, string moneda)
    {
        float resultado = 0;
        if (moneda == "euro")
        {
            resultado = cantidad * 1.11f;
        }
        else if ( moneda == "dolar")
        { 
            resultado = cantidad * 0.90f;
        }
        return resultado;
    }
}

