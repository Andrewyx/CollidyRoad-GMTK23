using System;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public enum GameState
{
    Playing,
    Paused,
    GameOver,
    Win
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    // single responsibility principle be damned
    public Button resumeButton;
    public Button quitButton;

    public GameObject[] uiElements;


    public void UpdateGameState(GameState gs)
    {
        switch (gs)
        {
            case GameState.Playing:
                foreach (var uiElement in uiElements)
                {
                    uiElement.SetActive(false);
                }
                Resume();
                break;
            case GameState.Paused:
                foreach (var uiElement in uiElements)
                {
                    uiElement.SetActive(true);
                }
                Pause();
                break;
            case GameState.GameOver:
                HandleGameOver();
                break;
            case GameState.Win:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(gs), gs, null);
        }
    }

    private void Awake()
    {
        uiElements = GameObject.FindGameObjectsWithTag("PauseMenu");
        resumeButton.onClick.AddListener(
            () =>
            {
                UpdateGameState(GameState.Playing);
            }
            );
        quitButton.onClick.AddListener(
            () =>
            {
                Application.Quit();
            }
            );
        UpdateGameState(GameState.Playing);
    }

    public void Update()
    {
        if (PlayerData.instance.lives <= 0)
        {
            UpdateGameState(GameState.GameOver);
        }

        if (PlayerData.instance.currentPoints >= 5 /* TODO: Change Later*/)
        {
            UpdateGameState(GameState.Win);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UpdateGameState(GameState.Paused);
        }
    }

    private void HandleGameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerData.instance.Reset();
    }
    
    private void Resume()
    {
        Time.timeScale = 1;
    }
    
    private void Pause()
    {
        Time.timeScale = 0;
    }
}