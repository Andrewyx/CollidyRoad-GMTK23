using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject Vehicle;
    public Transform VehicleSpawnLocation;
    // Start is called before the first frame update
    public int CarCost = 5;

    public void SpawnCar() {
        if(PlayerData.instance.currentPoints >= CarCost){
            Instantiate(Vehicle, VehicleSpawnLocation.position, Quaternion.identity);
            PlayerData.instance.currentPoints -= CarCost;
        }
        else{
            Debug.Log("too bad, you're poor");
        }
    }
    private void Update() {
        //Add a thing to change the colour of the button if you dont have enought currency to buy it
    }
}
