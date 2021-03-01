/* Logan Ross 
 * bus.cs 
 * Assignment 5 
 * The superclass that sets up all of the required infomation for the Vehicles
 */

using UnityEngine;
using System.Collections;


    public abstract class Vehicle : MonoBehaviour
    {
    private int maxSpeed;
    private string vehicleType;
    private int acceleration;
    private int gasMillage;

    private int speed;

    public void drive()
    {
        speed += acceleration;
        if (speed >= maxSpeed)
        {
            speed = maxSpeed;
        }
        transform.Translate((Vector3.forward * speed * Time.deltaTime)/25);
    }
    public int getMaxSpeed()
    {
        return maxSpeed;
    }
    protected void setMaxSpeed(int pMaxSpeed)
    {
        maxSpeed = pMaxSpeed;
    }
    public string getVehicleType()
    {
        return vehicleType;
    }
    protected void setVehicleType(string pVehicleType)
    {
        vehicleType = pVehicleType;
    }
    public int getAcceleration()
    {
        return acceleration;
    }
    protected void setAcceleration(int pAcceleration)
    {
        acceleration = pAcceleration;
    }
}
