using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private void Update()
    {
        Shott();
    }

    void Shott()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Debug.Log("Disparo");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100))
            {
                if(hit.collider.gameObject.tag == "Enemigo")
                {
                    Debug.Log("choque");
                   
                }
            }
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue, Mathf.Infinity);
        }
    }
}
