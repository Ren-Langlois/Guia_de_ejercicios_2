using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class while_01 : MonoBehaviour
{
    int counter = 1;
    int countermax = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (counter <= countermax)
        {
            Debug.Log(counter);
            counter++;
        }
        Debug.Log("termino el while");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
