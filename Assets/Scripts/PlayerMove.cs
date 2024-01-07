using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool turnLeft, turnRight;
    public float speed = 7.0f;
    //private Rigidbody playerRigidbody;
    private CharacterController myCharacter;
    //public string verticalAxis;
    //public string horizontalAxis;
    // Start is called before the first frame update
    void Start()
    {
        //playerRigidbody = GetComponent<Rigidbody>();
        //playerRigidbody.freezeRotation = true;
        myCharacter = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);

        if (turnLeft)
            myCharacter.transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
            myCharacter.transform.Rotate(new Vector3(0f, 90f, 0f));

        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(0f, 0f, 0f);
        //movement = transform.TransformDirection(movement); // Convert local to global space
        myCharacter.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacter.Move(transform.forward * speed * Time.deltaTime);
    }
}
