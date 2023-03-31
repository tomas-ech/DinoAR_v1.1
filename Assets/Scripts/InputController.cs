using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    
    public Joystick joystickMove;
    public Transform player;
    public float speed = 10f;
    public float turnSpeed = 5.0f;
    public BoxCollider boxCollider;

    private float x;
    

    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        boxCollider.enabled = true;
    }

    void Movement()
    {
        //input keyboard and joystick
        x = joystickMove.Horizontal + Input.GetAxis("Horizontal");
        
        //movement in a circle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * -x);
        transform.Rotate(new Vector3(30,0,0) * Time.deltaTime * turnSpeed * -x);

    }

    void Update()
    {
        Movement();
    }
}
