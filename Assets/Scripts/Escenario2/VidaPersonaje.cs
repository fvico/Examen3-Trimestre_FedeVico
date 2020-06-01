using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPersonaje : MonoBehaviour
{
    [SerializeField]int vida;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            Debug.Log("dañado");
        }
    }
}
