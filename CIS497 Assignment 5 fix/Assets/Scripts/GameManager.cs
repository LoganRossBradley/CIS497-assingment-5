/* Logan Ross 
 * GameManager.cs 
 * Assignment 5 
 * checks for player input
 */

using UnityEngine;
using System.Collections;
    
public class GameManager : MonoBehaviour   
{
    VehicleFactory vf;

    private void Awake()
    {
        vf = gameObject.GetComponent<VehicleFactory>();    
    }

    private void Update()
        {            
        if (Input.GetKeyDown(KeyCode.A))            
        {
            vf.createVehicle("Jeep");            
        }            
        else if (Input.GetKeyDown(KeyCode.S))           
        {
            vf.createVehicle("SportsCar");            
        }            
        else if (Input.GetKeyDown(KeyCode.D))           
        {       
            vf.createVehicle("Bus");           
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            int rand = Random.Range(0, 3);
            if (rand == 0)
            {
                vf.createVehicle("Jeep");
            }
            else if (rand == 1)
            {
                vf.createVehicle("SportsCar");
            }
            else if (rand == 2)
            {
                vf.createVehicle("Bus");
            }
        }       
    }    
}
