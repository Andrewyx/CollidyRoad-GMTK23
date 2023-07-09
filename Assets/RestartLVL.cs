using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLVL : MonoBehaviour
{
    public void RestartOnClick(){
        GameManager.instance.RestartLevel();
    }
    public void FullRestart(){
        GoToMenu();
        GameManager.instance.ReloopRun();
    }
    public void GoToMenu(){
        SceneManager.LoadScene("TitleScene");
    }    
    public void StartGame(){
        SceneManager.LoadScene("LVL1");
    }
    public void CreditScene(){
        SceneManager.LoadScene("CreditScene");
    }    
}
