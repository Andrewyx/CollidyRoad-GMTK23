using UnityEngine;

public class DeleteSound : MonoBehaviour
{
    [SerializeField] private float lifetime = 3.0f;

    private AudioSource _audioData;

    // Start is called before the first frame update
    private void Awake()
    {
        _audioData = GetComponent<AudioSource>();
        _audioData.Play();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0) Destroy(gameObject);
    }
}