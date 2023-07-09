using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLVL : MonoBehaviour
{
    public void RestartOnClick(){
        Debug.Log("i be clicked");
        GameManager.instance.RestartLevel();
    }
    public void GoToMenu(){
        SceneManager.LoadScene("TitleScene");
    }    
}
