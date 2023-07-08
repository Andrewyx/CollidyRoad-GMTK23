using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimal : MonoBehaviour
{
    [SerializeField] private int MaxEnemyHP = 1;
    private int CurrentEnemyHP;

    public GameObject Blood;
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioClip deathSound;
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
            Debug.Log(deathSoundEffect);
            if (!deathSoundEffect.isPlaying)
            {
                deathSoundEffect.Play();
                deathSoundEffect.PlayOneShot(deathSound, 1);
            }

            Debug.Log(deathSoundEffect.isPlaying);
            PlayerData.instance.IncreasePoints(MaxEnemyHP);
            Destroy(gameObject);
            Instantiate(Blood, transform.position, Quaternion.identity);
        }
    }
}
