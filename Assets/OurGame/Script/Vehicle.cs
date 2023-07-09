using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Vehicle : MonoBehaviour
{
    public float vehicleForce = 50f;
    public int vehicleHealth = 3;
    private Rigidbody2D _rb;
    private float _wreckageDuration = 2f;

    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector3(-50f, 0f).normalized * vehicleForce;
    }

    private void Update()
    {
        if (transform.position.x < -10f || transform.position.x > 10f) Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyAnimal enemyComponent)) enemyComponent.TakeDamage(1);
        DamageCar();
    }

    // Update is called once per frame
    private void DamageCar(int val = 1)
    {
        vehicleHealth -= val;
        if (vehicleHealth <= 0)
            //change sprite here and use wreckageDuration for the wait before destroying gameobj
            Destroy(gameObject);
    }
}