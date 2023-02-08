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
        
        Debug.Log(whichBarrel);
        Debug.Log(barrelTrigger);

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
        }
        else if (whichBarrel == "Wine")
        {
            Debug.Log("Holding Wine");
        }
        else if (whichBarrel == "Water")
        {
            Debug.Log("Holding Water");
        }
    }
}
