using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ButtonUI : MonoBehaviour
{
    public List<GameObject> vehicle;

    public Transform vehicleSpawnLocation;
    
    public GameObject button;
    public float zrotation = 0;

    // Start is called before the first frame update
    public int carCost = 5;
    private int _randomIndex;

    public void SpawnCar()
    {
        if (PlayerData.instance.currentPoints >= carCost)
        {
            _randomIndex = Random.Range(0, vehicle.Count);
            Instantiate(vehicle[_randomIndex], vehicleSpawnLocation.position, Quaternion.Euler(0, 0, zrotation));
            PlayerData.instance.currentPoints -= carCost;
        }
        else
        {
            Debug.Log("too bad, you're poor");
        }
    }

    private void Update()
    {
        // set color of button to grey if player doesn't have enough points
        // set color of button to yellow if player has enough points
        if (PlayerData.instance.currentPoints >= carCost)
        {
            button.GetComponent<Image>().color = Color.yellow;
        }
        else
        {
            button.GetComponent<Image>().color = Color.grey;
        }
    }
}