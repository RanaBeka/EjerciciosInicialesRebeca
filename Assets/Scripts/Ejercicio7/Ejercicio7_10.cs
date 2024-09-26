using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
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
            if (menor >= 0)
            {
                Debug.Log("el numero menor es positivo");
            }
            else
            {
                Debug.Log("el numero menor es negativo");
            }
            if (mayor >= 0)
            {
                Debug.Log("el numero mayor es positivo");
            }
            else
            {
                Debug.Log("el numero mayor es negativo");
            }
            if (menor % 2 == 0)
            {
                Debug.Log("el numero menor es par");
            }
            else
            {
                Debug.Log("el numero menor es impar");
            }
            if (mayor % 2 == 0)
            {
                Debug.Log("el numero mayor es par");
            }
            else
            {
                Debug.Log("el numero mayor es impar");
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
