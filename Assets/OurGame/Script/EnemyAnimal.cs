using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimal : MonoBehaviour
{
    [SerializeField] private int MaxEnemyHP = 1;
    private int CurrentEnemyHP;
    // Start is called before the first frame update
    void Start()
    {
        GameObject animal = GameObject.FindGameObjectWithTag("Animal");     
        Physics2D.IgnoreCollision(animal.GetComponent<Collider2D>(), GetComponent<Collider2D>());        
        CurrentEnemyHP = MaxEnemyHP;
    }
    public void TakeDamage(int damageAmount){
        CurrentEnemyHP -= damageAmount;
        if(CurrentEnemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
