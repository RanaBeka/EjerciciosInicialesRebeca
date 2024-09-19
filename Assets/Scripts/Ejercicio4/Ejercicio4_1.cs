using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        float resultado = AreaCirculo(2); 
        float resultado2 = AreaCuadrado(3);
        float resultado3 = AreaTriangulo(4, 6); 
        Debug.Log("Area circulo " + resultado);
        Debug.Log("Area cuadrado " + resultado2);
        Debug.Log("Area triangulo "+ resultado3);
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
    float AreaCuadrado(float lado)
    {
        float resultado2;
        resultado2 = lado * lado;
        return resultado2;
    }
    float AreaTriangulo(float base1, float altura)
    {
        float resultado3;
        resultado3 = (base1 * altura) / 2;
        return resultado3;
        
    }
}
