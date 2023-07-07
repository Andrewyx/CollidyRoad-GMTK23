using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private Rigidbody2D rb;
    public float VehicleForce = 50f;
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
        Destroy(gameObject); 
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x < -10f || transform.position.x > 10f){
            Destroy(gameObject);
        }
    }
}
