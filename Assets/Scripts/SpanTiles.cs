using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanTiles : MonoBehaviour
{

    public GameObject tile;
    public int spawnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0f, 0f, 0f);
        gameObject.transform.position = movement * spawnSpeed * Time.deltaTime;
    }
}
