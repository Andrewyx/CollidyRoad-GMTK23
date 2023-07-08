using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public enum GameState
{
    Playing,
    GameOver,
    Win
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Start()
    {
    }

    public void UpdateGameState(GameState gs)
    {
        switch (gs)
        {
            case GameState.Playing:
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
    }

    public void HandleGameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerData.instance.Reset();
    }
}