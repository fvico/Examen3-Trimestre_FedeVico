using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Actual vida: " + VidaEnemigo.currentVida);
    }
    private void Update()
    {
        Shott();
    }

    void Shott()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100))
            {
                if(hit.collider.gameObject.tag == "Enemigo")
                {
                    //currenteVidaEnemigo = currenteVidaEnemigo -1;
                    //VidaEnemigo.currentVida = currenteVidaEnemigo;
                    VidaEnemigo.currentVida = VidaEnemigo.currentVida - 1;
                    Debug.Log("ActualVida " + VidaEnemigo.currentVida);
                }
            }
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue, Mathf.Infinity);
        }
    }
}
