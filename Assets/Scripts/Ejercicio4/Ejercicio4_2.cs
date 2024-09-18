using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string completo = ConstruirNombre("A", "B", "C" );
        Debug.Log(completo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string ConstruirNombre(string nombre, string apellido1, string apellido2)
    {
        string completo;
        completo = ("La persona se llama " + nombre + " " + apellido1 + " " + apellido2);
        return completo;
    }
}
