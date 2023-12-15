using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // ENCAPSULATION
    private float speed;
    public float Speed {
        get { return speed; }
        protected set {
            if (value < 0) {
                Debug.LogError("Speed must be greater than zero.");
                return;
            } else {
                speed = value;
            }
        }
    }

    void Start()
    {
        Speed = 40;
    }

    void Update()
    {
        MoveForward();
        DestroyOutOfBounds();
    }

    // ABSTRACTION
    void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void DestroyOutOfBounds()
    {
        if (transform.position.z > topBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
