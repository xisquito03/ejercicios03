using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercico02 : MonoBehaviour
{
    public int number;

    private void Start()
    {
        isEven(number);
    }

    private bool isEven(int num)
    {
        if (num % 2 == 0)
        {
            Debug.Log("The number is even");
            return true;
            
        }
        else
        {
            Debug.Log("The number is not even"); 
            return false;
           
        }
    }


}
