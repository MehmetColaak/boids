using System;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{
    private int moveSpeed = 1;
    private Vector3 particleDirection;

    void Start()
    {
        particleDirection = new Vector3(UnityEngine.Random.Range(1f, -1f), UnityEngine.Random.Range(1f, -1f), 0).normalized;
        Debug.Log(particleDirection);
    }

    void Update()
    {
        particleDirection = new Vector3(UnityEngine.Random.Range(1f, -1f), UnityEngine.Random.Range(1f, -1f), 0).normalized;
        this.transform.Translate(particleDirection * Time.deltaTime * moveSpeed);
    }
    
}
