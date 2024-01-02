using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool turnLeft, turnRight;
    public float speed = 7.0f;
    private Rigidbody playerRigidbody;
    //public string verticalAxis;
    //public string horizontalAxis;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerRigidbody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);

        if (turnLeft)
            playerRigidbody.transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
            playerRigidbody.transform.Rotate(new Vector3(0f, 90f, 0f));

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement = transform.TransformDirection(movement); // Convert local to global space
        playerRigidbody.velocity = movement * speed * Time.deltaTime;
    }
}
