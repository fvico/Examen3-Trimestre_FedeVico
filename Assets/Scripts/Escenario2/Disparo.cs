using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
   public AudioSource sonidoEnemigo;
   public GameObject prefabBlood;
    public GameObject spawnBlood;
    private void Start()
    {
        Debug.Log("Actual vida: " + VidaEnemigo.currentVida);
        sonidoEnemigo = GetComponent<AudioSource>();
       
    }
    private void Update()
    {
        Shott();
        sonidoEnemigo.Play();
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
                    VidaEnemigo.currentVida = VidaEnemigo.currentVida - 1;
                    Debug.Log("ActualVida " + VidaEnemigo.currentVida);
                    Sound.sonido.reproductor.clip = Sound.sonido.listaSonidos[0];
                    Sound.sonido.reproductor.Play();
                    InvocarSangre();
                }
            }
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue, Mathf.Infinity);
        }
    }

   public void InvocarSangre()
    {
        Instantiate(prefabBlood, spawnBlood.transform.position,Quaternion.identity);
    }
}
