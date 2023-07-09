using UnityEngine;

public class DialogueButton : MonoBehaviour
{
    public GameObject[] background;
    private int _index;


    private void Start()
    {
        _index = 0;
        Next();
    }

    // Update is called once per frame
    private void Update()
    {
    
        if (_index == 0) background[0].gameObject.SetActive(true);
    }

    public void Next()
    {
        
        for (var i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[_index].gameObject.SetActive(true);
        }

        Debug.Log(_index);
        _index += 1;
    }

    //private boolean set to true
    // once goes through entire list, set to false 
}