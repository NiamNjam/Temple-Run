using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool turnLeft, turnRight;
    public float speed;
    //private Rigidbody playerRigidbody;
    private CharacterController myCharacter;
    public GameObject tile;
    public GameObject tileEnd;
    public Vector3 cooStraight;
    public Vector3 cooLeft;
    public Vector3 cooRight;
    List<int> tilesList = new List<int>();
    private List<GameObject> instantiatedTiles = new List<GameObject>();
   

    void Start()
    {

        myCharacter = GetComponent<CharacterController>();
        GameObject instantiatedTile = Instantiate(tile, new Vector3(2f,0,0), Quaternion.identity);
        tileEnd = instantiatedTile.gameObject.transform.GetChild(0).gameObject;
        Vector3 tilePosition = tileEnd.transform.position;
        Debug.Log("Position of the instantiated tile: " + tilePosition);
        //int tileNr = Random.Range(0, 10);
        //tilesList.Add(tileNr);
        //int lastDigit = tilesList[tilesList.Count - 1] * 3;
        //print(lastDigit);
        /*
        for (int i = 0; i < 10; i++)
        {
            Instantiate(tile, i * cooStraight, Quaternion.identity);
            GameObject newTile = Instantiate(tile, (i + 1) * cooStraight, Quaternion.identity);
            instantiatedTiles.Add(newTile);

        }
        if (instantiatedTiles.Count > 0)
        {
            GameObject lastInstantiatedTile = instantiatedTiles[instantiatedTiles.Count - 1];
            // Do something with the last instantiated tile, for example:
            lastInstantiatedTile.GetComponent<Renderer>().material.color = Color.red;
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(tile, i * cooLeft, Quaternion.identity);
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(tile, i * cooRight, Quaternion.identity);
        }
        */

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
