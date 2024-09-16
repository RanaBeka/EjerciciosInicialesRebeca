using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 1;
    int vidasPlayer2 = 2;
    int vidasPlayer3 = 3;   
    int vidasPlayer4 = 4;
    int vidasPlayer2Again;
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2Again = vidasPlayer2;
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasPlayer2Again;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
