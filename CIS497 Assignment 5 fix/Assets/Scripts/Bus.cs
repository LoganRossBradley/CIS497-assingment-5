/* Logan Ross 
 * bus.cs 
 * Assignment 5 
 * runs the Bus object which is a child of the Vehicle superclass
 */

using UnityEngine;
using System.Collections;


    public class Bus : Vehicle
{

        // Use this for initialization
        void Start()
        {
        setAcceleration(1);
        setMaxSpeed(1500);
        setVehicleType("Bus");
    }

        // Update is called once per frame
        void Update()
        {
        drive();
        }
    }