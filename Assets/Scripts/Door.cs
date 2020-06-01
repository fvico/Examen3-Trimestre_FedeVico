using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Animator animator;
    private bool estaBajada;
    private int numeroLLaves;
    public Sound sonido;
    public Text textoLLave;
    private void Start()
    {
       
        estaBajada = false;
        animator.SetBool("EstaBajada", estaBajada);
        
    }
    private void Update()
    {
        numeroLLaves = Player.numeroLLaves;
    }

    IEnumerator TextoLLave()
    {
        textoLLave.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        textoLLave.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && numeroLLaves==1)
        {
            estaBajada = !estaBajada;
            animator.SetBool("EstaBajada", estaBajada);
            Debug.Log("Numero de Llaves"+numeroLLaves);
            sonido.reproductor.clip = sonido.listaSonidos[0];
            sonido.reproductor.Play();

        }
        else if(other.tag == "Player" && numeroLLaves < 1)
        {
            StartCoroutine("TextoLLave");
            sonido.reproductor.clip = sonido.listaSonidos[2];
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
