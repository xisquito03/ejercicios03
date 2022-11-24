using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio09 : MonoBehaviour
{
    public int bases;
    public int height;

    private void Start()
    {
        Area(bases, height);
    }

    private void Area(int num1, int num2)
    {
        if (num1 > 0 && num2 > 0)
        {
            Debug.Log($"El area de el triangulo es {num1 * num2 / 2}");
        }
        else
        {
            Debug.Log($"El area de estos valores no se pueden calcular.");
        }
    }

}
