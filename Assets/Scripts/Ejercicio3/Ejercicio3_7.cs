using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float base1;
    [SerializeField] float altura;
    [SerializeField] float area;
    // Start is called before the first frame update
    void Start()
    {
        area = base1 * altura / 2;
        Debug.Log(area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
