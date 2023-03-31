using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotator : MonoBehaviour
{
    public float rotatorSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(1f, 1f, 1f) * rotatorSpeed);
        
    }
}
