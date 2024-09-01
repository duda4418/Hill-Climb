using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectFuel : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.gameObject.CompareTag("Player"))
        {
            FuelControl.instance.FillFuel();
            Destroy(gameObject);
        }
    }
}
