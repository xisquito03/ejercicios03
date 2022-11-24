using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio04 : MonoBehaviour
{
    public Vector3 subir=new Vector3(0,1,0);

    private void Start()
    {
        Movimiento(subir);
    }

    private void Movimiento(Vector3 subida)
    {
        transform.position = subida;
    }
}
