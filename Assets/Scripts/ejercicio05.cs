using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio05 : MonoBehaviour
{
    public int number;

    private void Start()
    {
        tabla(number);
    }

    private void tabla(int multiplo)
    {
        Debug.Log($"{multiplo * 1}, {multiplo * 2}, {multiplo * 3}, {multiplo * 4}, {multiplo * 5}, {multiplo * 6}, { multiplo * 7}, {multiplo * 8}, {multiplo * 9}, {multiplo * 10}");
    }
}
