using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AutoLoadNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float loadtime = 1.5f;

    // Update is called once per frame
    void Update()
    {
        loadtime -= Time.deltaTime;
        if(loadtime <= 0){
            if(SceneManager.GetActiveScene().name == "LVL1"){
                SceneManager.LoadScene("PlayScene1");
            }
        else if (SceneManager.GetActiveScene().name == "LVL2"){
                SceneManager.LoadScene("PlayScene2");
            }
        else if (SceneManager.GetActiveScene().name == "LVL3"){
                SceneManager.LoadScene("PlayScene3");
            }                
        }
    }
}
