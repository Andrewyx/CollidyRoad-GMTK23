using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ResumerUIElement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().clicked += () =>
        {
            GameManager.instance.UpdateGameState(
                GameState.Playing
            );
        };
    }
}
