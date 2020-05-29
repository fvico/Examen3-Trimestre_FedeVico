using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    private bool estaBajada;
    private AudioSource sound;
    private int numeroLLaves;
    private void Start()
    {
        sound = GetComponent<AudioSource>();
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
            sound.Play();
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && numeroLLaves == 1)
        {
            estaBajada = !estaBajada;
            animator.SetBool("EstaBajada", estaBajada);
            Debug.Log("sali");
            sound.Play();
        }
        
    }
}
