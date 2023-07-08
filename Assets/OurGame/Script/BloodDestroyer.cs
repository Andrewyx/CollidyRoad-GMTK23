using UnityEngine;

public class BloodDestroyer : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        Destroy(gameObject, 3f);
    }
}