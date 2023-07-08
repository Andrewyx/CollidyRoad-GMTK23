using System.Collections;
using System.Collections.Generic;
using OurGame.Scripts;
using UnityEngine;

public class EnemyAnimal : MonoBehaviour
{
    [SerializeField] private int MaxEnemyHP = 1;
    private int CurrentEnemyHP;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(8, 8);   
        CurrentEnemyHP = MaxEnemyHP;
    }
    public void TakeDamage(int damageAmount){
        CurrentEnemyHP -= damageAmount;
        if(CurrentEnemyHP <= 0)
        {
            PlayerData.Points++;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
