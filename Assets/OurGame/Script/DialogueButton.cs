using UnityEngine;

public class DialogueButton : MonoBehaviour
{
    public GameObject[] background;
    private int _index;
    
    // timer for each dialogue background elem
    // once timer is up, move to next dialogue background elem
    int secondsBetweenDialogue = 10;
    float timer;

    public int startSlide;
    public int endSlide;

    private void Start()
    {
        _index = startSlide;
        Next();
    }

    // Update is called once per frame
    private void Update()
    {
    
        if (_index == startSlide) background[startSlide].gameObject.SetActive(true);
        timer += Time.deltaTime;
        
        if (timer > secondsBetweenDialogue)
        {
            Next();
        }
        // 
    }

    public void Next()
    {
        timer = 0f;

        for (var i = startSlide; i < endSlide; i++)
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