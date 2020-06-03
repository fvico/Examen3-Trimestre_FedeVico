using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    public GameObject controles;

    private void Awake()
    {
        controles.SetActive(false);
    }
    public void Controles()
    {
        controles.SetActive(true);
    }

    public void Atras()
    {
        controles.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("ExamenProgramacion");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("pincho");
    }
}

