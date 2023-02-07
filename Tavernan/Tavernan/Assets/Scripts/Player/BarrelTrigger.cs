using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarrelTrigger : MonoBehaviour
{
    [SerializeField] private GameObject beerBarrel;
    [SerializeField] private GameObject wineBarrel;
    [SerializeField] private GameObject waterBarrel;

    private string whichBarrel;

    private void Update()
    {
        Debug.Log(whichBarrel);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Beer")
        {
            whichBarrel = "Beer";
        }
        if (trigger.gameObject.tag == "Wine")
        {
            whichBarrel = "Wine";
        }
        if (trigger.gameObject.tag == "Water")
        {
            whichBarrel = "Water";
        }
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        whichBarrel = "None";
    }
}
