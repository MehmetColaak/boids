using System;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{
    private int moveSpeed = 1;
    private Vector3 particleDirection;
    private float lastDirectionChangeTime;

    void Start()
    {
        lastDirectionChangeTime = Time.time;
        UpdateParticleDirection();
        Debug.Log(particleDirection);
    }

    void Update()
    {
        // Check if 0,3 seconds have passed since the last direction change
        if (Time.time - lastDirectionChangeTime >= 0.3f)
        {
            UpdateParticleDirection();
        }

        // Move the particle based on the current direction
        this.transform.Translate(particleDirection * Time.deltaTime * moveSpeed);
    }

    void UpdateParticleDirection()
    {
        // Generate a new random direction
        particleDirection = new Vector3(UnityEngine.Random.Range(1f, -1f), UnityEngine.Random.Range(1f, -1f), 0).normalized;
        
        // Update the last direction change time
        lastDirectionChangeTime = Time.time;
    }
}
