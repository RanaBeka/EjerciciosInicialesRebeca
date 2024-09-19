using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    void Start()
    {
        float resultado = AreaCirculo(2);
        float resultadoA = Convertir(resultado, "euro");
        Debug.Log(resultadoA);
    }

    // Update is called once per frame
    void Update()
    {

    }
    float AreaCirculo(float radio)
    {
        float resultado;
        resultado = (radio * radio) * 3.14f;
        return resultado;
    }
    
    float Convertir(float cantidad, string moneda)
    {
        float resultadoA = 0;
        if (moneda == "euro")
        {
            resultadoA = cantidad * 1.11f;
        }
        else if (moneda == "dolar")
        {
            resultadoA = cantidad * 0.90f;
        }
        return resultadoA;
    }
}
