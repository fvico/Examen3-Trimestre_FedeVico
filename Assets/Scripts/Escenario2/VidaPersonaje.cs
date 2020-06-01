using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPersonaje : MonoBehaviour
{
    [SerializeField]int vida;
    public GameManager gameManager;

    private void Update()
    {
        if (vida <= 0)
        {
            gameManager.GameOver();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            vida = vida - 25;
        }
    }
}
