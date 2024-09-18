using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    [SerializeField] float longitud;
    [SerializeField] float area;
    // Start is called before the first frame update
    void Start()
    {
        longitud = 2f*3.14f * radio;
        Debug.Log(longitud);
        area = 3.14f * radio*radio;
        Debug.Log(area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
