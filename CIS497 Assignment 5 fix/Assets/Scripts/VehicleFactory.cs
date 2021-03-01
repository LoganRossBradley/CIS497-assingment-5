/* Logan Ross 
 * bus.cs 
 * Assignment 5 
 * what actually creates the different objects
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleFactory : MonoBehaviour
{
    public Vector3 spawnPoint = new Vector3(0,0,0);
    public Quaternion spawnRotation = new Quaternion(0, 0, 0, 0);

    public GameObject jeep;
    public GameObject sportsCar;
    public GameObject bus;

    public void createVehicle(string vehicleType)
    {
        if(vehicleType == "Jeep")
        {
            Instantiate(jeep, spawnPoint, spawnRotation) ;
        }
        else if(vehicleType == "SportsCar")
        {
            Instantiate(sportsCar, spawnPoint, spawnRotation);
        }
        else if(vehicleType == "Bus")
        {
            Instantiate(bus, spawnPoint, spawnRotation);
        }
        else
        {
            Debug.Log("Invalid vehicle type passed into vehicle factory");
        }
    }
}
