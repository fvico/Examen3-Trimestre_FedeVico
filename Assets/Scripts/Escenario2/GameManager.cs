using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject winner;
    public GameObject menu;


    private void Start()
    {
        Time.timeScale = 1;
        gameOver.SetActive(false);
        winner.SetActive(false);
        menu.SetActive(false);
    }

    public void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        gameOver.SetActive(true);
        Time.timeScale = 0;
        menu.SetActive(true);
    }

    public void Winner()
    {
        winner.SetActive(true);
        menu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

    }
}
