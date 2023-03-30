using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WowSpawn : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public Transform[] spawnLocation;

    void Start()
    {

        for(int i = 0; i < spawnLocation.Length; i++)
        {
            Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnLocation[i]);
        }


        
        //Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnLocation[Random.Range(0, spawnLocation.Length)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
