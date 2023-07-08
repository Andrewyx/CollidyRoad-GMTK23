using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance;
    public TMP_Text pointText;
    public TMP_Text livesText;
    public int currentPoints;
    public int lives = 3;

    public float timePerPassiveIncome = 3f;

    public int passiveIncomeVal = 5;
    private float _initialtimePerPassiveIncome = 3f;

    private int _maxLives;

    private void Awake()
    {
        instance = this;
    }

    public void Reset()
    {
        lives = _maxLives;
        currentPoints = 0;
    }

    // Start is called before the first frame update
    private void Start()
    {
        pointText.text = "Nugget Coins: " + currentPoints;
        livesText.text = "Lives: " + lives;
        _maxLives = lives;
        _initialtimePerPassiveIncome = timePerPassiveIncome;
    }

    private void Update()
    {
        timePerPassiveIncome -= Time.deltaTime;
        if (timePerPassiveIncome <= 0)
        {
            IncreasePoints(passiveIncomeVal);
            timePerPassiveIncome = _initialtimePerPassiveIncome;
        }
    }

    public void IncreasePoints(int val)
    {
        currentPoints += val;
        pointText.text = "Nugget Coins: " + currentPoints;
    }

    public void DecreaseLives(int val)
    {
        lives -= val;
        livesText.text = "Lives: " + lives;
    }
}