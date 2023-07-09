using System;
using Udar.SceneManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = System.Object;

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

    public int numKilled;

    public int killToNextLevel;

    public int pointsToNextLevel = 50; // should never be more than number of enemies spawned in the game,
                                       // or else the game will never end
                                       
    [SerializeField] private SceneField nextLevel;

    private GameObject[] _uiElements;
    private bool _gameState = true;

    private void Awake()
    {
        _uiElements = GameObject.FindGameObjectsWithTag("PauseMenu");
        resumeButton.onClick.AddListener(
            () => { UpdateGameState(GameState.Playing); }
        );
        quitButton.onClick.AddListener(
            () => { Application.Quit(); }
        );
        UpdateGameState(GameState.Playing);
    }

    public void Update()
    {
        if (PlayerData.instance.lives <= 0) UpdateGameState(GameState.GameOver);

        if (PlayerData.instance.currentPoints >= pointsToNextLevel /* TODO: Change Later*/) UpdateGameState(GameState.Win);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _gameState = !_gameState;
            if (_gameState)
                UpdateGameState(GameState.Playing);
            else
                UpdateGameState(GameState.Paused);
        }

        if (numKilled >= killToNextLevel)
        {
            UpdateGameState(GameState.Win);
        }
    }


    public void UpdateGameState(GameState gs)
    {
        switch (gs)
        {
            case GameState.Playing:
                foreach (var uiElement in _uiElements) uiElement.SetActive(false);
                Resume();
                break;
            case GameState.Paused:
                foreach (var uiElement in _uiElements) uiElement.SetActive(true);
                Pause();
                break;
            case GameState.GameOver:
                HandleGameOver();
                break;
            case GameState.Win:
                Debug.Log($"Loading next scene named: {nextLevel.Name}");
                SceneManager.LoadScene(nextLevel.Name);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(gs), gs, null);
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