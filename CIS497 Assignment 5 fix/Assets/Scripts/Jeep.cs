/* Logan Ross 
 * Jeep.cs 
 * Assignment 5 
 * runs the Jeep object which is a child of the Vehicle superclass
 */

using UnityEngine;
using System.Collections;

    public class Jeep : Vehicle
    {

        // Use this for initialization
        void Start()
        {
        setAcceleration(2);
        setMaxSpeed(3000);
        setVehicleType("Jeep");
        }

        // Update is called once per frame
        void Update()
        {
        drive();
        }
    }
