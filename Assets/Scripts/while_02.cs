using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class while_02 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        while (num1 < num2)
        {
            Debug.Log(num1);
            num1++;
        }
        Debug.Log("Los numeros son iguales");
        while (num2 < num1)
        {
            Debug.Log(num2);
            num2++;
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
