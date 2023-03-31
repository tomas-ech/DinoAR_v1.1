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

    float x;
    float z;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
    }

    void Movement()
    {
        x = joystickMove.Horizontal + Input.GetAxis("Horizontal");
        z = joystickMove.Vertical + Input.GetAxis("Vertical");
        move = player.right * x + player.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
}
