using System.Collections;
using System.Collections.Generic;
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
        
        // Debug.Log(
        //     transform.position.y
        //     );
        
        
        if (transform.position.y >= 4)
        {
            
            PlayerData.instance.DecreaseLives(1);
            Destroy(
                gameObject
                );
        }
    }
}