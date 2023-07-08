using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance;
    public TMP_Text pointText;
    public TMP_Text livesText;
    public int currentPoints = 0;
    public int lives = 3;

    private int maxLives;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        pointText.text = "Nugget Coins: " + currentPoints.ToString(); 
        livesText.text = "Lives: " + lives.ToString(); 
        maxLives = lives;
    }
    
    public void IncreasePoints(int val){
        currentPoints += val;
        pointText.text = "Nugget Coins: " + currentPoints.ToString(); 
    }
    public void DecreaseLives(int val){
        lives -= val;
        livesText.text = "Lives: " + lives.ToString(); 
    }
    public void Reset(){
        lives = maxLives;
        currentPoints = 0;
    }
}