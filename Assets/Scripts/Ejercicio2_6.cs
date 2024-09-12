using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 3;
    int puntuacion2 = 7;
    int puntuacion3 = 5;
    float media;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(puntuacion1 + " " + puntuacion2 + " " + puntuacion3);
        media = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
        Debug.Log(media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
