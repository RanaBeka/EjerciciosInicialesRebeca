using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float radio;
    [SerializeField] float base1;
    [SerializeField] float altura;
    [SerializeField] float lado;
    float resultado;
    float resultado2;
    float resultado3;
    // Start is called before the first frame update
    void Start()
    {
        AreaCirculo();
        AreaCuadrado();
        AreaTriangulo();
        Debug.Log("Area circulo " + resultado);
        Debug.Log("Area cuadrado " + resultado2);
        Debug.Log("Area triangulo "+ resultado3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float AreaCirculo()
    {
        resultado = (radio * radio) * 3.14f;
        return resultado;
    }
    float AreaCuadrado()
    {
        resultado2 = lado * lado;
        return resultado2;
    }
    float AreaTriangulo()
    {
        resultado3 = (base1 * altura) / 2;
        return resultado3;
        
    }
}
