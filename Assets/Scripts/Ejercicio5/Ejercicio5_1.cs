using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejericicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1;
    [SerializeField] int vida2;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log(" La batalla est� re�ida");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
