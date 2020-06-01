using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    [SerializeField] int vidaMaxima;
    public static int currentVida;
    public GameManager gameManager;
    public GameObject spawnerEnemigo;


    private void Start()
    {
        
        currentVida = vidaMaxima;
        //currentVida = 100;

    }
    private void Update()
    {
        if (currentVida <= 0)
        {
            gameManager.Winner();
            Destroy(spawnerEnemigo);

        }
    }
}
