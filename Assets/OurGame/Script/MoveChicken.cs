using UnityEngine;
using Udar.SceneManager;
using UnityEngine.SceneManagement;
public class MoveChicken : MonoBehaviour
{
    public float speed;
    public int pointsOnKill;

    public Transform target;


    private void Update()
    {
        // transform.position = Vector3.MoveTowards(
        // transform.position,
        // target.position,
        // speed * Time.deltaTime
        // );

        // make the chicken only go up
        transform.Translate(
            Vector3.up * speed * Time.deltaTime
        );

        // constrain chicken rotation to only upwards

        transform.rotation = Quaternion.Euler(
            0,
            0,
            0
        );

        // Debug.Log(
        //     transform.position.y
        //     );


        if (transform.position.y >= 4 && SceneManager.GetActiveScene().name == "PlayScene1")
        {
            PlayerData.instance.DecreaseLives(1);
            Destroy(
                gameObject
            );
        }
        else if (transform.position.y >= 9 && SceneManager.GetActiveScene().name == "PlayScene2")
        {
            PlayerData.instance.DecreaseLives(1);
            Destroy(
                gameObject
            );
        }      
        else if (transform.position.y >= 9 && SceneManager.GetActiveScene().name == "PlayScene3")
        {
            PlayerData.instance.DecreaseLives(1);
            Destroy(
                gameObject
            );
        }                
    }
}