using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private Rigidbody2D rb;
    public float VehicleForce = 50f;
    public int VehicleHealth = 3;
    private float wreckageDuration = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-50f, 0f).normalized * VehicleForce;
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.TryGetComponent<EnemyAnimal>(out EnemyAnimal enemyComponent))
        {
            
            enemyComponent.TakeDamage(1);
        }
        DamageCar(1);
    }
    // Update is called once per frame
    private void DamageCar(int val =1){
        VehicleHealth -= val;
        if(VehicleHealth <= 0){
            //change sprite here and use wreckageDuration for the wait before destroying gameobj
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(transform.position.x < -10f || transform.position.x > 10f){
            Destroy(gameObject);
        }
    }
}
