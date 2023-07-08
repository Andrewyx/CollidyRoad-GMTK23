using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
<<<<<<< HEAD
    public static class PlayerData
    {
        public static int Points { get; set; }
        public static int lives = 3;

        public static void Reset()
        {
            Points = 0;
            lives = 3;
        }
=======
    public static PlayerData instance;
    public TMP_Text pointText;
    public TMP_Text livesText;
    public int currentPoints = 0;
    public int lives = 3;

    private int maxLives;

    private void Awake() {
        instance = this;
>>>>>>> bab086ee4d1203f00f8a6b18d83a1a05e5654ce5
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
