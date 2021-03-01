/* Logan Ross 
 * SportsCar.cs 
 * Assignment 5 
 * runs the SportsCar object which is a child of the Vehicle superclass
 */

using UnityEngine;
using System.Collections;


    public class SportsCar : Vehicle
    {

        // Use this for initialization
        void Start()
        {
        setAcceleration(4);
        setMaxSpeed(5000);
        setVehicleType("SportsCar");
    }

        // Update is called once per frame
        void Update()
        {
        drive();
        }
    }
