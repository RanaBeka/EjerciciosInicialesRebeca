using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    float temperatura;
    bool frío;
    bool nublado;
    bool caluroso;
    bool tropical;
    // Start is called before the first frame update
    void Start()
    {
        if ( temperatura <= 10 )
        {
            frío = true;
        }
        else if ( temperatura > 10 && temperatura <= 20)
        {
            nublado = true;
        }
        else if ( temperatura > 20 && temperatura <= 30)
        {
            caluroso = true;
        }
        else if ( temperatura > 30)
        {
            tropical = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
