using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        float mS = Convertir(5);
        Debug.Log(mS);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Convertir(float kmHora)
    {
        float mS;
        mS = kmHora * 3.6f;
        return mS;

    }
}
