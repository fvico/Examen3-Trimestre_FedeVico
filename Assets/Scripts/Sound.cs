using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static Sound sonido;
    public List<AudioClip> listaSonidos; 
    public AudioSource reproductor;

    private void Start()
    {
        sonido = GetComponent<Sound>();
        reproductor = GetComponent<AudioSource>();
    }
}
