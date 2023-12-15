using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : Units
{
    // INHERITANCE
    // POLYMORPHISM
    void Start()
    {
        Speed = 19;
    }

    void OnTriggerEnter(Collider other)
    {
        // Deactivate the food and destroy the animal
        other.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
