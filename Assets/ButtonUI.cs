using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject Vehicle;
    public Transform VehicleSpawnLocation;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SpawnCar() {
        Instantiate(Vehicle, VehicleSpawnLocation.position, Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
