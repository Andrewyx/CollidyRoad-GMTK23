using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ButtonUI : MonoBehaviour
{
    public List<GameObject> vehicle;

    public Transform vehicleSpawnLocation;

    // Start is called before the first frame update
    public int carCost = 5;
    private int _randomIndex;

    public void SpawnCar()
    {
        if (PlayerData.instance.currentPoints >= carCost)
        {
            _randomIndex = Random.Range(0, vehicle.Count);
            Instantiate(vehicle[_randomIndex], vehicleSpawnLocation.position, Quaternion.identity);
            PlayerData.instance.currentPoints -= carCost;
        }
        else
        {
            Debug.Log("too bad, you're poor");
        }
    }
}