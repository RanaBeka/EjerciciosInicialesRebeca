using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int vida = 120;
    // Start is called before the first frame update
    void Start()
    {
        vida = 3 % vida;
        Debug.Log("Queda " + vida + " de vida");
        vida = 3 % vida;
        Debug.Log("Queda " + vida + " de vida");
        vida = 3 % vida;
        Debug.Log("Queda " + vida + " de vida");
        vida = 3 % vida;
        Debug.Log("Queda " + vida + " de vida");
        vida = 3 % vida;
        Debug.Log("Queda " + vida + " de vida");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
