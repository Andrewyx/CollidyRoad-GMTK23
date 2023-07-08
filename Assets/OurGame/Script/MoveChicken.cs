using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChicken : MonoBehaviour
{
    public float speed;
    public int pointsOnKill;

    public Transform target;

   [SerializeField] private AudioSource deathSoundEffect; 
   // [SerializeField] private AudioSource walkingSoundEffect; 

    private void Update()
    {
       // walkingSoundEffect.Play(); 
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

            PlayerData.instance.DecreaseLives(1);
            Destroy(
                gameObject
                );
            deathSoundEffect.Play(); 
        }
    }
}