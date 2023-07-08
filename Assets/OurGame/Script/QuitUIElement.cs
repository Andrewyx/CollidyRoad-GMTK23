using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuitUIElement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().clicked += Application.Quit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
