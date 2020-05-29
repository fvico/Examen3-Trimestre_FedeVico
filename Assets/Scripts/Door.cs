using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    private bool estaBajada;
    private AudioSource sound;
    private void Start()
    {
        sound = GetComponent<AudioSource>();
        estaBajada = false;
        animator.SetBool("EstaBajada", estaBajada);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            estaBajada = !estaBajada;
            animator.SetBool("EstaBajada", estaBajada);
            Debug.Log("entre");
            sound.Play();
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            estaBajada = !estaBajada;
            animator.SetBool("EstaBajada", estaBajada);
            Debug.Log("sali");
            sound.Play();
        }
        
    }
}
