using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSound : MonoBehaviour
{
    AudioSource audioData;

    [SerializeField] private float lifetime = 3.0f;
    // Start is called before the first frame update
    void Awake()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lifetime -= Time.deltaTime;
        if(lifetime <= 0){
            Destroy(gameObject);
        }
    }
}
