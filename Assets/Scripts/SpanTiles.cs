using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanTiles : MonoBehaviour
{
    public GameObject player;
    public GameObject tileToSpawn;
    public GameObject referenceObject;
    public GameObject badTile;
    public GameObject bigTile;
    public float distanceBetweenTiles = 2.5F;
    public float randomValue = 0.9f;
    private Vector3 previousTilePosition;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
        int betweenN = Random.Range(-1,1);
        previousTilePosition = referenceObject.transform.position;
        InvokeRepeating("Road", 0.2f, 0.2f);
        InvokeRepeating("Danger", 1f, 1f);
    }

    // Update is called once per frame
    void Road()
    {
        Vector3 mainDirection = new Vector3(0, 0, 1);
        Vector3 otherDirection = new Vector3(1, 0, 0);
        
        if (Random.value < randomValue)
        {
            direction = mainDirection;
        }
        else
        {
            Vector3 temp = direction;
            direction = otherDirection;
            mainDirection = direction;
            otherDirection = temp;

        }
        Vector3 spawnPos = previousTilePosition + 4F * direction;
        Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
        Instantiate(bigTile, spawnPos, Quaternion.Euler(0, 40, 0));
        previousTilePosition = spawnPos;

    }

    void Danger() 
    {
        Vector3 mainDirection = new Vector3(0, 0, 1);
        Vector3 otherDirection = new Vector3(1, 0, 0);

        if (Random.value < randomValue)
        {
            direction = mainDirection;
        }
        else
        {
            Vector3 temp = direction;
            direction = otherDirection;
            mainDirection = direction;
            otherDirection = temp;

        }
        Vector3 spawnPos = previousTilePosition + 2F * direction;
        Instantiate(badTile, spawnPos, Quaternion.Euler(0, 0, 0));
        previousTilePosition = spawnPos;
    }

    



}
