using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    Transform cam;
    public Joystick joystickMove;
    public Joystick joystickCam;

    public Transform player;
    public CharacterController controller;

    public float speed = 10f;
    public float turnSpeed = 5.0f;

    float x;
    float y;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
    }

    void Movement()
    {
        x = joystickMove.Horizontal + Input.GetAxis("Horizontal");
        y = joystickMove.Vertical + Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * x);
        transform.Rotate(new Vector3(30,0,0) * Time.deltaTime * turnSpeed * x);

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
}
