using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examples : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Create", frequency, frequency);


        //Vector3 tilePosition = tileStart.transform.position;
        //Debug.Log("Position of the instantiated tile: " + tilePosition);

        //GameObject tileStart1 = instantiatedTile1.transform.GetChild(0).gameObject;
        //tileStart.transform.position = tileStart1.transform.position;
        //int tileNr = Random.Range(0, 10);
        //tilesList.Add(tileNr);
        //int lastDigit = tilesList[tilesList.Count - 1] * 3;
        //print(lastDigit);
        /*
        GameObject instantiatedTile = Instantiate(tile, new Vector3(3f, 0, 0), Quaternion.identity);
        GameObject tileStart = instantiatedTile.transform.GetChild(1).gameObject;
        GameObject tileLeft = instantiatedTile.transform.GetChild(2).gameObject;
        GameObject tileRight = instantiatedTile.transform.GetChild(3).gameObject;
        instantiatedTiles.Add(tileStart);
        instantiatedTiles.Add(tileLeft);
        instantiatedTiles.Add(tileRight);
        if (instantiatedTiles.Count > 0)
        {
            int randomIndex = Random.Range(0, instantiatedTiles.Count);
            GameObject randomSide = instantiatedTiles[randomIndex];
            Debug.Log("Position of the instantiated tile: " + randomSide.transform.position);
            GameObject instantiatedTile1 = Instantiate(tile, randomSide.transform.position, Quaternion.identity);

        }
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
        }
        */
    }
    // Update is called once per frame
    void Update()
    {

    }
}
