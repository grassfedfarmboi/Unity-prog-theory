using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    protected float speed;
    private float topBound = 30;
    private float lowerBound = -10;

    void Start()
    {
        speed = 40;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        DestroyOutOfBounds();
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
