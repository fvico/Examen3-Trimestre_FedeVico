using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject winner;


    private void Start()
    {
        Time.timeScale = 1;
        gameOver.SetActive(false);
        winner.SetActive(false);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Winner()
    {
        winner.SetActive(true);
       
    }
}
