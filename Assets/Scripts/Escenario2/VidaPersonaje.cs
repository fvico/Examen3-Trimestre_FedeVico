using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPersonaje : MonoBehaviour
{
    [SerializeField]int vidamaxima;
    private int currentVida;
    public GameManager gameManager;
    public Text textoSalud;
    public Animator panelDaño;
    private AudioSource sonido;

    private void Start()
    {
        currentVida = vidamaxima;
    }
    private void Update()
    {
        textoSalud.text = "Salud: " + currentVida.ToString();
        if (currentVida <= 0)
        {
            gameManager.GameOver();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            currentVida = currentVida - 25;
            panelDaño.SetTrigger("Daño");
            Sound.sonido.reproductor.clip = Sound.sonido.listaSonidos[1];
            Sound.sonido.reproductor.Play();
            Destroy(other.gameObject);
        }
    }
}
