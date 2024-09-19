using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float kmHora;
    float mS;
    // Start is called before the first frame update
    void Start()
    {
        mS = kmHora * 3.6f;
        Debug.Log(kmHora + " son " + mS);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
