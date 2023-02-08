using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlacementTrigger : MonoBehaviour
{
    public bool placementSpotTrigger;

    private void Update()
    {
        //Debug.Log(placementSpotTrigger);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "PlacementSpots")
        {
            placementSpotTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        placementSpotTrigger = false;
    }
}
