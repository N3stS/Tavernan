using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarrelTrigger : MonoBehaviour
{
    public string whichBarrel;
    public bool barrelTrigger;

    private void Update()
    {
        //Debug.Log(barrelTrigger);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Beer")
        {
            whichBarrel = "Beer";
            barrelTrigger = true;
        }
        else if (trigger.gameObject.tag == "Wine")
        {
            whichBarrel = "Wine";
            barrelTrigger = true;
        }
        else if (trigger.gameObject.tag == "Water")
        {
            whichBarrel = "Water";
            barrelTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        whichBarrel = "None";
        barrelTrigger = false;
    }
}
