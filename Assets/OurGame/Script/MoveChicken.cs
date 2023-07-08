using System;
using OurGame.Scripts;
using UnityEngine;

public class MoveChicken : MonoBehaviour
{
    public float speed;
    public int pointsOnKill;

    public Transform target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
            );
        
        Debug.Log(
            transform.position.y
            );


        if (transform.position.y >= 4)
        {
            PlayerData.lives--;
            Destroy(gameObject);
        }
    }
    
    


    // put this on your enemy prefabs. You could just copy the on destroy onto a pre-existing script if you want.
    private void OnDestroy()
    {
        PlayerData.Points += pointsOnKill;

    }
}