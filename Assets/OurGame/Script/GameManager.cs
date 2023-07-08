using System;
using UnityEngine.SceneManagement;
using UnityEngine;

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

    public void UpdateGameState(GameState gs)
    {
        switch (gs)
        {
            case GameState.Playing:
                Resume();
                break;
            case GameState.Paused:
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