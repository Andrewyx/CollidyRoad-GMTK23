using UnityEngine;
using UnityEngine.Serialization;

public class EnemyAnimal : MonoBehaviour
{
    private int maxEnemyHp = 1;

    public GameObject blood;
    public GameObject deathSoundClone;
    private int _currentEnemyHp;

    // Start is called before the first frame update
    private void Start()
    {
        Physics2D.IgnoreLayerCollision(8, 8);
        _currentEnemyHp = maxEnemyHp;
    }

    public void TakeDamage(int damageAmount)
    {
        _currentEnemyHp -= damageAmount;

        if (_currentEnemyHp <= 0)
        {
            Instantiate(deathSoundClone, transform.position, Quaternion.identity);
            PlayerData.instance.IncreasePoints(maxEnemyHp);
            CinemachineShake.Instance.ShakeCameraSharp(2f, 0.1f);
            Destroy(gameObject);
            Instantiate(blood, transform.position, Quaternion.identity);
        }
    }
}