using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : Units
{
    void Start()
    {
        speed = 19;
    }

    void OnTriggerEnter(Collider other)
    {
        // Deactivate the food and destroy the animal
        other.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
