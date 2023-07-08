using UnityEngine;

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


        if (transform.position.y >= 4)
        {
            PlayerData.instance.DecreaseLives(1);
            Destroy(
                gameObject
            );
        }
    }
}