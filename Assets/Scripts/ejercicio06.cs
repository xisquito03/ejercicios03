using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio06 : MonoBehaviour
{
    public int number1;
    public int number2;

    private void Start()
    {
        IsGreater(number1, number2);
    }
    
    private int IsGreater(int num1, int num2)
    {
        if(num1 > num2)
        {
            Debug.Log($"{num1} is larger");
            return num1;

        }
        else
        {
            Debug.Log($"{num2} is larger");
            return num1;
        }
    }
}
