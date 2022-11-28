using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Subida();
        }
    }

    private void Subida()
    {
        transform.localScale += Vector3.one;


    }
}
