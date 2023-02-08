using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private string whichBarrel;
    private bool placemetSpotTrigger;
    private bool barrelTrigger;
    private string heldBeverage = "None";

    private void Awake()
    {
        whichBarrel = GetComponent<BarrelTrigger>().whichBarrel;
        placemetSpotTrigger = GetComponent<PlacementTrigger>().placementSpotTrigger;
        barrelTrigger = GetComponent<BarrelTrigger>().barrelTrigger;
    }

    private void Update()
    {
        whichBarrel = GetComponent<BarrelTrigger>().whichBarrel;
        placemetSpotTrigger = GetComponent<PlacementTrigger>().placementSpotTrigger;
        barrelTrigger = GetComponent<BarrelTrigger>().barrelTrigger;
        
        MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        
        //Debug.Log(whichBarrel);
        //Debug.Log(barrelTrigger);
        Debug.Log(heldBeverage);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (barrelTrigger)
            {
                PickUpBeverage();
            }
            else
            {
                Debug.Log("No Beverage");
            }

            if (placemetSpotTrigger)
            {
                PlaceBeverage();
            }
            else
            {
                Debug.Log("No Held Beverage");
            }
        }
    }

    private void MoveCharacter(Vector2 direction)
    {
        transform.Translate((direction * (speed * Time.deltaTime)));
    }

    private void PickUpBeverage()
    {
        if (whichBarrel == "Beer")
        {
            Debug.Log("Holding Beer");
            heldBeverage = "Beer";
        }
        else if (whichBarrel == "Wine")
        {
            Debug.Log("Holding Wine");
            heldBeverage = "Wine";
        }
        else if (whichBarrel == "Water")
        {
            Debug.Log("Holding Water");
            heldBeverage = "Water";
        }
    }

    private void PlaceBeverage()
    {
        if (placemetSpotTrigger)
        {
            if (heldBeverage == "Beer")
            {
                Debug.Log("You Place Down Beer");
                heldBeverage = "None";
            }
            else if (heldBeverage == "Wine")
            {
                Debug.Log("You Place Down Wine");
                heldBeverage = "None";
            }
            else if (heldBeverage == "Water")
            {
                Debug.Log("You Place Down Water");
                heldBeverage = "None";
            }
        }
    }
}
