using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    private bool estaBajada;
    private int numeroLLaves;
    public Sound sonido;
    private void Start()
    {
       
        estaBajada = false;
        animator.SetBool("EstaBajada", estaBajada);
        
    }
    private void Update()
    {
        numeroLLaves = Player.numeroLLaves;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && numeroLLaves==1)
        {
            estaBajada = !estaBajada;
            animator.SetBool("EstaBajada", estaBajada);
            Debug.Log("entre");
            Debug.Log("Numero de Llaves"+numeroLLaves);
            sonido.reproductor.clip = sonido.listaSonidos[0];
            sonido.reproductor.Play();

        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && numeroLLaves == 1)
        {
            estaBajada = !estaBajada;
            animator.SetBool("EstaBajada", estaBajada);
            Debug.Log("sali");
            sonido.reproductor.clip = sonido.listaSonidos[0];
            sonido.reproductor.Play();
        }
        
    }
}
