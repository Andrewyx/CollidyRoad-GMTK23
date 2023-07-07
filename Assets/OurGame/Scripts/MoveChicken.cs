using UnityEngine;

public class MoveChicken : MonoBehaviour
{
    public float speed;
    public float pointsOnKill;

    public Transform target;

    private void Update()
    {
        var dir = target.transform.position - transform.position;
        var distanceThisFrame = speed * Time.deltaTime;
        
        if (dir.magnitude <= distanceThisFrame)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        }

    }
    
    


    // put this on your enemy prefabs. You could just copy the on destroy onto a pre-existing script if you want.
    private void OnDestroy()
    {
        if (GameObject.FindGameObjectWithTag("WaveSpawner") != null)
            GameObject.FindGameObjectWithTag("WaveSpawner").GetComponent<WaveSpawner>().spawnedEnemies
                .Remove(gameObject);
    }
}