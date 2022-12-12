using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tabToStart;
    public GameObject scoreText;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        tabToStart.SetActive(true);
        scoreText.SetActive(false);
        PauseGame();

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }

    public void GameOver()
    {
        scoreText.SetActive(false);
        gameOverPanel.SetActive(true);
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        scoreText.SetActive(true);
        tabToStart.SetActive(false);
        Time.timeScale = 1f;
    }
}
