using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio07 : MonoBehaviour
{
    public int number;

    private void Start()
    {
        Absolute(number);
    }

    private int Absolute(int num)
    {
        if (num >= 0)
        {
            Debug.Log($"The absolute value is {num}");
            return num;
        }
        else
        {
            Debug.Log($"The absolute value is {num * -1}");
            return num;
        }
        // if(num<0)
        // num * -1
        // Debug.Log($"The absolute value is {num}
    }

}
