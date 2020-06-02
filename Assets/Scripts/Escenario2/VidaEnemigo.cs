using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEnemigo : MonoBehaviour
{
    [SerializeField] int vidaMaxima;
    public static int currentVida;
    public GameManager gameManager;
    public GameObject spawnerEnemigo;
    public Text vidaEnemigo;



    private void Start()
    {
        
        currentVida = vidaMaxima;
        //currentVida = 100;

    }
    private void Update()
    {
        vidaEnemigo.text = "Vida Enemigo: " + currentVida.ToString();
        if (currentVida <= 0)
        {
            currentVida = 0;
            gameManager.Winner();
            Destroy(spawnerEnemigo);

        }

    }
}
