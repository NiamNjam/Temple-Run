using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool turnLeft, turnRight;
    public float speed = 7.0f;
    private Rigidbody playerRigidbody;
    private CharacterController playerController;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerRigidbody.freezeRotation = true;
        //playerController = GetComponent<CharacterController>();
        
    }

    void Update()
    {
        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);

        if (turnLeft)
            transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
            transform.Rotate(new Vector3(0f, 90f, 0f));

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        //playerController.SimpleMove(new Vector3(0f, 0f, 0f));
        movement = transform.TransformDirection(movement);
        playerRigidbody.Move(movement * speed * Time.deltaTime);
    }
}
