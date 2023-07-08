using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimal : MonoBehaviour
{
    [SerializeField] private int MaxEnemyHP = 1;
    private int CurrentEnemyHP;

    public GameObject Blood;
    [SerializeField] private AudioSource deathSoundEffect; 
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
            PlayerData.instance.IncreasePoints(MaxEnemyHP);
            Destroy(gameObject);
            Instantiate(Blood, transform.position, Quaternion.identity);
            deathSoundEffect.Play(); 

        }
    }
}
