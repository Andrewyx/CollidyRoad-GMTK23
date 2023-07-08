using UnityEngine;

public class DialogueButton : MonoBehaviour
{
    public GameObject[] background;
    private int _index;


    private void Start()
    {
        _index = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if (_index >= 4)
            _index = 4;

        if (_index < 0)
            _index = 0;

        if (_index == 0) background[0].gameObject.SetActive(true);
    }

    public void Next()
    {
        _index += 1;

        for (var i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[_index].gameObject.SetActive(true);
        }

        Debug.Log(_index);
    }
}