using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio03 : MonoBehaviour
{
    public int dividend;
    public int divisor;

    private void Start()
    {
        isExact(dividend, divisor);

    }

    private void isExact(int num1, int num2)
    {
        if(num1 % num2== 0)
        {
            Debug.Log("This division is exact");
        }
        else
        {
            Debug.Log("This division is not exact");
        }
    }
}
