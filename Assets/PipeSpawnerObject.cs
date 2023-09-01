using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerObject : MonoBehaviour
{

    public GameObject pipe;
    public float spawnedObject = 10;

    private float timer = 0;
    public float heightoffset = 5;


    // Start is called before the first frame update
    void Start()
    {
        spawnedObjects();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnedObject)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnedObjects();

            timer = 0;
        }

    }


    void spawnedObjects()
    {
        float lowestPoint = transform.position.y - heightoffset;
        float heighestPoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,heighestPoint),0), transform.rotation);
    }
}
